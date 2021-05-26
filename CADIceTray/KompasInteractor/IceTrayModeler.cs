using CADIceTray;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace KompasInteractor
{
    /// <summary>
    /// Создание модели.
    /// </summary>
    public class IceTrayModeler
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="kompas">Интерфейс API компаса.</param>
        public IceTrayModeler(KompasObject kompas)
        {
            _kompas = kompas;
        }

        /// <summary>
        /// Создание модели на основе входных параметров.
        /// </summary>
        /// <param name="parameters">Размеры.</param>
        public void CreateModel(IceTrayParameters parameters)
        {
            _doc3D = (ksDocument3D)_kompas.Document3D();
            _doc3D.Create();
            _doc3D = (ksDocument3D)_kompas.ActiveDocument3D();
            _part = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
            var currentPlane = (ksEntity)_part.GetDefaultEntity(
                (short)Obj3dType.o3d_planeXOY);
            var angle = 10;
            DrawRectangle(parameters[ParameterName.Length], 
                parameters[ParameterName.Width], 0, 0, 
                currentPlane, angle);
            MakeExtrude(parameters[ParameterName.Height], _entitySketch);

            CreateCells(parameters[ParameterName.CellLength], 
                parameters[ParameterName.CellWidth], 
                parameters[ParameterName.CellHeight], 
                currentPlane);
        }

        /// <summary>
        /// Создать ячейки.
        /// </summary>
        private void CreateCells(double length, double width, double height, 
            ksEntity currentPlane)
        {
            const double wallThickness = 5;
            const double angle = 5;
            DrawRectangle(length, width, wallThickness, wallThickness, 
                currentPlane, angle);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtReverse, 
                height);

            DrawRectangle(length, width, length + wallThickness*2, 
                wallThickness, currentPlane, angle);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtReverse, 
                height);

            DrawRectangle(length, width, wallThickness, 
                width + wallThickness*2, currentPlane, angle);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtReverse, 
                height);

            DrawRectangle(length, width, length + wallThickness*2, 
                width + wallThickness*2, currentPlane, angle);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtReverse, 
                height);
        }

        /// <summary>
        /// Создать эскиз.
        /// </summary>
        /// <param name="currentPlane">Плоскость, на которой будет создан
        /// эскиз.</param>
        private void CreateSketch(ksEntity currentPlane)
        {
            _entitySketch = (ksEntity)_part.NewEntity(
                (short)Obj3dType.o3d_sketch);
            _sketchDefinition = 
                (ksSketchDefinition)_entitySketch.GetDefinition();
            _sketchDefinition.SetPlane(currentPlane);
            _entitySketch.Create();
        }

        /// <summary>
        /// Выдавливание.
        /// </summary>
        /// <param name="depth">Глубина выдавливания.</param>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        private void MakeExtrude(double depth, object entitySketch)
        {
            var entityExtrude = (ksEntity)_part.NewEntity(
                (short)Obj3dType.o3d_baseExtrusion);
            var entityExtrudeDefinition = (
                ksBaseExtrusionDefinition)entityExtrude.GetDefinition();
            entityExtrudeDefinition.SetSideParam(true, 0, depth);
            entityExtrudeDefinition.SetSketch(entitySketch);
            entityExtrude.Create();
        }

        /// <summary>
        /// Вырезать выдавливанием.
        /// </summary>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        /// <param name="direction">Направление выдавливания.</param>
        /// <param name="depth">Глубина выреза.</param>
        private void MakeCutExtrude(object entitySketch, short direction, double depth)
        {
            var entityCutExtrusion = (ksEntity)_part.NewEntity(
                (short)Obj3dType.o3d_cutExtrusion);
            var cutExtrusionDefinition = (
                ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition();
            cutExtrusionDefinition.directionType = direction;
            cutExtrusionDefinition.SetSideParam(false, 0, depth);
            cutExtrusionDefinition.SetSketch(entitySketch);
            entityCutExtrusion.Create();
        }

        /// <summary>
        /// Нарисовать прямоугольник.
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="x">Координата базовой точки x пря­моугольника </param>
        /// <param name="y">координата базовой точки y пря­моугольника </param>
        /// <param name="currentPlane">Плоскость на которой рисуется
        /// прямоугольник.</param>
        /// <param name="corner">Размер угла.</param>
        private void DrawRectangle(double length, double width, double x,
            double y, ksEntity currentPlane, double corner)
        {
            CreateSketch(currentPlane);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            var param = (ksRectangleParam)_kompas.GetParamStruct(
                (short)StructType2DEnum.ko_RectangleParam);
            param.ang = 0;
            param.height = length;
            param.width = width;
            param.style = 1;
            param.x = x;
            param.y = y;
            var corners = Corners(param, corner);
            param.SetPCorner(corners);
            _sketchEdit.ksRectangle(param);
            _sketchDefinition.EndEdit();
        }

        /// <summary>
        /// Создание свойств углов прямоугольника.
        /// </summary>
        /// <param name="param">Свойства прямоугольника.</param>
        /// <param name="corner">Размер угла.</param>
        /// <returns></returns>
        private ksDynamicArray Corners(ksRectangleParam param, double corner)
        {
            var corners = (ksDynamicArray)param.GetPCorner();
            var cornerParams = (ksCornerParam)_kompas.GetParamStruct(
                (short)StructType2DEnum.ko_CornerParam);
            cornerParams.Init();
            for (var i = 0; i < 4; i++)
            {
                cornerParams.index = i + 1;
                cornerParams.fillet = true;
                cornerParams.l1 = corner;
                cornerParams.l2 = corner;
                corners.ksAddArrayItem(-1, cornerParams);
            }
            return corners;
        }

        /// <summary>
        ///  Указатель на экземпляр компаса.
        /// </summary>
        private readonly KompasObject _kompas;

        /// <summary>
        ///  Указатель на интерфейс документа.
        /// </summary>
        private ksDocument3D _doc3D;

        /// <summary>
        ///  Указатель на интерфейс компонента.
        /// </summary>
        private ksPart _part;

        /// <summary>
        ///  Указатель на интерфейс сущности.
        /// </summary>
        private ksEntity _entitySketch;

        /// <summary>
        ///  Указатель на интерфейс параметров эскиза.
        /// </summary>
        private ksSketchDefinition _sketchDefinition;

        /// <summary>
        ///  Указатель на эскиз.
        /// </summary>
        private ksDocument2D _sketchEdit;
    }
}