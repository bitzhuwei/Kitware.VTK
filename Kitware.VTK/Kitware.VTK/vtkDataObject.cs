using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataObject : vtkObject
	{
		public enum AttributeTypes
		{
			CELL = 1,
			EDGE = 5,
			FIELD = 2,
			NUMBER_OF_ATTRIBUTE_TYPES = 7,
			POINT = 0,
			POINT_THEN_CELL = 3,
			ROW = 6,
			VERTEX = 4
		}

		public enum FieldAssociations
		{
			FIELD_ASSOCIATION_CELLS = 1,
			FIELD_ASSOCIATION_EDGES = 5,
			FIELD_ASSOCIATION_NONE = 2,
			FIELD_ASSOCIATION_POINTS = 0,
			FIELD_ASSOCIATION_POINTS_THEN_CELLS = 3,
			FIELD_ASSOCIATION_ROWS = 6,
			FIELD_ASSOCIATION_VERTICES = 4,
			NUMBER_OF_ASSOCIATIONS = 7
		}

		public enum FieldOperations
		{
			FIELD_OPERATION_MODIFIED = 2,
			FIELD_OPERATION_PRESERVED = 0,
			FIELD_OPERATION_REINTERPOLATED,
			FIELD_OPERATION_REMOVED = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObject";

		public new static readonly string MRClassNameKey;

		static vtkDataObject()
		{
			vtkDataObject.MRClassNameKey = "class vtkDataObject";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObject"));
		}

		public vtkDataObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObject New()
		{
			vtkDataObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataObject.vtkDataObject_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_Register_83(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkDataObject.vtkDataObject_Register_83(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_UnRegister_120(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkDataObject.vtkDataObject_UnRegister_120(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_CELL_DATA_VECTOR_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey CELL_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_CELL_DATA_VECTOR_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_CopyInformation_02(HandleRef pThis, HandleRef data);

		public void CopyInformation(vtkDataObject data)
		{
			vtkDataObject.vtkDataObject_CopyInformation_02(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_CopyInformationFromPipeline_03(HandleRef pThis, HandleRef request);

		public virtual void CopyInformationFromPipeline(vtkInformation request)
		{
			vtkDataObject.vtkDataObject_CopyInformationFromPipeline_03(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_CopyInformationToPipeline_04(HandleRef pThis, HandleRef request, HandleRef input, HandleRef output, int forceCopy);

		public virtual void CopyInformationToPipeline(vtkInformation request, vtkInformation input, vtkInformation output, int forceCopy)
		{
			vtkDataObject.vtkDataObject_CopyInformationToPipeline_04(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), forceCopy);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_CopyInformationToPipeline_05(HandleRef pThis, HandleRef request, HandleRef input);

		public void CopyInformationToPipeline(vtkInformation request, vtkInformation input)
		{
			vtkDataObject.vtkDataObject_CopyInformationToPipeline_05(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_CopyTypeSpecificInformation_06(HandleRef pThis, HandleRef data);

		public virtual void CopyTypeSpecificInformation(vtkDataObject data)
		{
			vtkDataObject.vtkDataObject_CopyTypeSpecificInformation_06(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_Crop_07(HandleRef pThis);

		public virtual void Crop()
		{
			vtkDataObject.vtkDataObject_Crop_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_EXTENT_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerPointerKey DATA_EXTENT()
		{
			vtkInformationIntegerPointerKey vtkInformationIntegerPointerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_EXTENT_08(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerPointerKey = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerPointerKey.Register(null);
				}
			}
			return vtkInformationIntegerPointerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_EXTENT_TYPE_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DATA_EXTENT_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_EXTENT_TYPE_09(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_GEOMETRY_UNMODIFIED_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DATA_GEOMETRY_UNMODIFIED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_GEOMETRY_UNMODIFIED_10(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DATA_NUMBER_OF_GHOST_LEVELS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_NUMBER_OF_GHOST_LEVELS_11(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_NUMBER_OF_PIECES_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DATA_NUMBER_OF_PIECES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_NUMBER_OF_PIECES_12(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_OBJECT_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDataObjectKey DATA_OBJECT()
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_OBJECT_13(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_PIECE_NUMBER_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DATA_PIECE_NUMBER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_PIECE_NUMBER_14(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_RESOLUTION_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleKey DATA_RESOLUTION()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_RESOLUTION_15(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_TIME_STEPS_16(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey DATA_TIME_STEPS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_TIME_STEPS_16(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_DATA_TYPE_NAME_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey DATA_TYPE_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_DATA_TYPE_NAME_17(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_DataHasBeenGenerated_18(HandleRef pThis);

		public void DataHasBeenGenerated()
		{
			vtkDataObject.vtkDataObject_DataHasBeenGenerated_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_DeepCopy_19(HandleRef pThis, HandleRef src);

		public virtual void DeepCopy(vtkDataObject src)
		{
			vtkDataObject.vtkDataObject_DeepCopy_19(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_EDGE_DATA_VECTOR_20(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey EDGE_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_EDGE_DATA_VECTOR_20(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_ACTIVE_ATTRIBUTE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ACTIVE_ATTRIBUTE_21(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_ARRAY_NAME_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey FIELD_ARRAY_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ARRAY_NAME_22(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_ARRAY_TYPE_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_ARRAY_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ARRAY_TYPE_23(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_ASSOCIATION_24(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_ASSOCIATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ASSOCIATION_24(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_ATTRIBUTE_TYPE_25(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_ATTRIBUTE_TYPE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_ATTRIBUTE_TYPE_25(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_NAME_26(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey FIELD_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_NAME_26(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_NUMBER_OF_COMPONENTS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_NUMBER_OF_COMPONENTS_27(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_NUMBER_OF_TUPLES_28(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_NUMBER_OF_TUPLES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_NUMBER_OF_TUPLES_28(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_OPERATION_29(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FIELD_OPERATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_OPERATION_29(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_FIELD_RANGE_30(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey FIELD_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_FIELD_RANGE_30(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetActiveFieldInformation_31(HandleRef info, int fieldAssociation, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformation GetActiveFieldInformation(vtkInformation info, int fieldAssociation, int attributeType)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetActiveFieldInformation_31((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataObject_GetActualMemorySize_32(HandleRef pThis);

		public virtual uint GetActualMemorySize()
		{
			return vtkDataObject.vtkDataObject_GetActualMemorySize_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetAssociationTypeAsString_33(int associationType);

		public static string GetAssociationTypeAsString(int associationType)
		{
			return Marshal.PtrToStringAnsi(vtkDataObject.vtkDataObject_GetAssociationTypeAsString_33(associationType));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetAttributeTypeForArray_34(HandleRef pThis, HandleRef arr);

		public virtual int GetAttributeTypeForArray(vtkAbstractArray arr)
		{
			return vtkDataObject.vtkDataObject_GetAttributeTypeForArray_34(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetAttributes_35(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSetAttributes GetAttributes(int type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetAttributes_35(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetAttributesAsFieldData_36(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetAttributesAsFieldData_36(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetData_37(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataObject GetData(vtkInformation info)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetData_37((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetData_38(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataObject GetData(vtkInformationVector v, int i)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetData_38((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetDataObjectType_39(HandleRef pThis);

		public virtual int GetDataObjectType()
		{
			return vtkDataObject.vtkDataObject_GetDataObjectType_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetDataReleased_40(HandleRef pThis);

		public virtual int GetDataReleased()
		{
			return vtkDataObject.vtkDataObject_GetDataReleased_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataObject_GetEstimatedMemorySize_41(HandleRef pThis);

		public virtual uint GetEstimatedMemorySize()
		{
			return vtkDataObject.vtkDataObject_GetEstimatedMemorySize_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetExtentTranslator_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExtentTranslator GetExtentTranslator()
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetExtentTranslator_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetExtentType_43(HandleRef pThis);

		public virtual int GetExtentType()
		{
			return vtkDataObject.vtkDataObject_GetExtentType_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetFieldData_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFieldData GetFieldData()
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetFieldData_44(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetGlobalReleaseDataFlag_45();

		public static int GetGlobalReleaseDataFlag()
		{
			return vtkDataObject.vtkDataObject_GetGlobalReleaseDataFlag_45();
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetInformation_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetInformation_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataObject_GetMTime_47(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkDataObject.vtkDataObject_GetMTime_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetMaximumNumberOfPieces_48(HandleRef pThis);

		public virtual int GetMaximumNumberOfPieces()
		{
			return vtkDataObject.vtkDataObject_GetMaximumNumberOfPieces_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetNamedFieldInformation_49(HandleRef info, int fieldAssociation, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformation GetNamedFieldInformation(vtkInformation info, int fieldAssociation, string name)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetNamedFieldInformation_49((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataObject_GetNumberOfElements_50(HandleRef pThis, int type);

		public virtual long GetNumberOfElements(int type)
		{
			return vtkDataObject.vtkDataObject_GetNumberOfElements_50(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetPipelineInformation_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetPipelineInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetPipelineInformation_51(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataObject_GetPipelineMTime_52(HandleRef pThis);

		public uint GetPipelineMTime()
		{
			return vtkDataObject.vtkDataObject_GetPipelineMTime_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetProducerPort_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetProducerPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetProducerPort_53(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetReleaseDataFlag_54(HandleRef pThis);

		public int GetReleaseDataFlag()
		{
			return vtkDataObject.vtkDataObject_GetReleaseDataFlag_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetRequestExactExtent_55(HandleRef pThis);

		public virtual int GetRequestExactExtent()
		{
			return vtkDataObject.vtkDataObject_GetRequestExactExtent_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetSource_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSource GetSource()
		{
			vtkSource vtkSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetSource_56(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSource = (vtkSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSource.Register(null);
				}
			}
			return vtkSource;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetUpdateExtent_57(HandleRef pThis);

		public virtual int[] GetUpdateExtent()
		{
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetUpdateExtent_57(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GetUpdateExtent_58(HandleRef pThis, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

		public virtual void GetUpdateExtent(ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
		{
			vtkDataObject.vtkDataObject_GetUpdateExtent_58(base.GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GetUpdateExtent_59(HandleRef pThis, IntPtr extent);

		public virtual void GetUpdateExtent(IntPtr extent)
		{
			vtkDataObject.vtkDataObject_GetUpdateExtent_59(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetUpdateGhostLevel_60(HandleRef pThis);

		public virtual int GetUpdateGhostLevel()
		{
			return vtkDataObject.vtkDataObject_GetUpdateGhostLevel_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetUpdateNumberOfPieces_61(HandleRef pThis);

		public virtual int GetUpdateNumberOfPieces()
		{
			return vtkDataObject.vtkDataObject_GetUpdateNumberOfPieces_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_GetUpdatePiece_62(HandleRef pThis);

		public virtual int GetUpdatePiece()
		{
			return vtkDataObject.vtkDataObject_GetUpdatePiece_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataObject_GetUpdateTime_63(HandleRef pThis);

		public uint GetUpdateTime()
		{
			return vtkDataObject.vtkDataObject_GetUpdateTime_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetWholeBoundingBox_64(HandleRef pThis);

		public virtual double[] GetWholeBoundingBox()
		{
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetWholeBoundingBox_64(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GetWholeBoundingBox_65(HandleRef pThis, ref double x0, ref double x1, ref double y0, ref double y1, ref double z0, ref double z1);

		public virtual void GetWholeBoundingBox(ref double x0, ref double x1, ref double y0, ref double y1, ref double z0, ref double z1)
		{
			vtkDataObject.vtkDataObject_GetWholeBoundingBox_65(base.GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GetWholeBoundingBox_66(HandleRef pThis, IntPtr extent);

		public virtual void GetWholeBoundingBox(IntPtr extent)
		{
			vtkDataObject.vtkDataObject_GetWholeBoundingBox_66(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_GetWholeExtent_67(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkDataObject.vtkDataObject_GetWholeExtent_67(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GetWholeExtent_68(HandleRef pThis, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

		public virtual void GetWholeExtent(ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
		{
			vtkDataObject.vtkDataObject_GetWholeExtent_68(base.GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GetWholeExtent_69(HandleRef pThis, IntPtr extent);

		public virtual void GetWholeExtent(IntPtr extent)
		{
			vtkDataObject.vtkDataObject_GetWholeExtent_69(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GlobalReleaseDataFlagOff_70(HandleRef pThis);

		public void GlobalReleaseDataFlagOff()
		{
			vtkDataObject.vtkDataObject_GlobalReleaseDataFlagOff_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_GlobalReleaseDataFlagOn_71(HandleRef pThis);

		public void GlobalReleaseDataFlagOn()
		{
			vtkDataObject.vtkDataObject_GlobalReleaseDataFlagOn_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_Initialize_72(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkDataObject.vtkDataObject_Initialize_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_IsA_73(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataObject.vtkDataObject_IsA_73(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_IsTypeOf_74(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataObject.vtkDataObject_IsTypeOf_74(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_NewInstance_76(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject NewInstance()
		{
			vtkDataObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_NewInstance_76(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_ORIGIN_77(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey ORIGIN()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_ORIGIN_77(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_PIECE_EXTENT_78(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerVectorKey PIECE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_PIECE_EXTENT_78(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_PIECE_FIELD_RANGE_79(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey PIECE_FIELD_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_PIECE_FIELD_RANGE_79(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_POINT_DATA_VECTOR_80(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey POINT_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_POINT_DATA_VECTOR_80(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_PrepareForNewData_81(HandleRef pThis);

		public virtual void PrepareForNewData()
		{
			vtkDataObject.vtkDataObject_PrepareForNewData_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_PropagateUpdateExtent_82(HandleRef pThis);

		public virtual void PropagateUpdateExtent()
		{
			vtkDataObject.vtkDataObject_PropagateUpdateExtent_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_ReleaseData_84(HandleRef pThis);

		public void ReleaseData()
		{
			vtkDataObject.vtkDataObject_ReleaseData_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_ReleaseDataFlagOff_85(HandleRef pThis);

		public virtual void ReleaseDataFlagOff()
		{
			vtkDataObject.vtkDataObject_ReleaseDataFlagOff_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_ReleaseDataFlagOn_86(HandleRef pThis);

		public virtual void ReleaseDataFlagOn()
		{
			vtkDataObject.vtkDataObject_ReleaseDataFlagOn_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_RemoveNamedFieldInformation_87(HandleRef info, int fieldAssociation, string name);

		public static void RemoveNamedFieldInformation(vtkInformation info, int fieldAssociation, string name)
		{
			vtkDataObject.vtkDataObject_RemoveNamedFieldInformation_87((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_RequestExactExtentOff_88(HandleRef pThis);

		public virtual void RequestExactExtentOff()
		{
			vtkDataObject.vtkDataObject_RequestExactExtentOff_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_RequestExactExtentOn_89(HandleRef pThis);

		public virtual void RequestExactExtentOn()
		{
			vtkDataObject.vtkDataObject_RequestExactExtentOn_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_SIL_90(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDataObjectKey SIL()
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SIL_90(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_SPACING_91(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey SPACING()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SPACING_91(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_SafeDownCast_92(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObject SafeDownCast(vtkObjectBase o)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SafeDownCast_92((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_SetActiveAttribute_93(HandleRef info, int fieldAssociation, string attributeName, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformation SetActiveAttribute(vtkInformation info, int fieldAssociation, string attributeName, int attributeType)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_SetActiveAttribute_93((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, attributeName, attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetActiveAttributeInfo_94(HandleRef info, int fieldAssociation, int attributeType, string name, int arrayType, int numComponents, int numTuples);

		public static void SetActiveAttributeInfo(vtkInformation info, int fieldAssociation, int attributeType, string name, int arrayType, int numComponents, int numTuples)
		{
			vtkDataObject.vtkDataObject_SetActiveAttributeInfo_94((info == null) ? default(HandleRef) : info.GetCppThis(), fieldAssociation, attributeType, name, arrayType, numComponents, numTuples);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetExtentTranslator_95(HandleRef pThis, HandleRef translator);

		public void SetExtentTranslator(vtkExtentTranslator translator)
		{
			vtkDataObject.vtkDataObject_SetExtentTranslator_95(base.GetCppThis(), (translator == null) ? default(HandleRef) : translator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetFieldData_96(HandleRef pThis, HandleRef arg0);

		public virtual void SetFieldData(vtkFieldData arg0)
		{
			vtkDataObject.vtkDataObject_SetFieldData_96(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetGlobalReleaseDataFlag_97(int val);

		public static void SetGlobalReleaseDataFlag(int val)
		{
			vtkDataObject.vtkDataObject_SetGlobalReleaseDataFlag_97(val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetInformation_98(HandleRef pThis, HandleRef arg0);

		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkDataObject.vtkDataObject_SetInformation_98(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetMaximumNumberOfPieces_99(HandleRef pThis, int arg0);

		public virtual void SetMaximumNumberOfPieces(int arg0)
		{
			vtkDataObject.vtkDataObject_SetMaximumNumberOfPieces_99(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetPipelineInformation_100(HandleRef pThis, HandleRef arg0);

		public virtual void SetPipelineInformation(vtkInformation arg0)
		{
			vtkDataObject.vtkDataObject_SetPipelineInformation_100(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetPointDataActiveScalarInfo_101(HandleRef info, int arrayType, int numComponents);

		public static void SetPointDataActiveScalarInfo(vtkInformation info, int arrayType, int numComponents)
		{
			vtkDataObject.vtkDataObject_SetPointDataActiveScalarInfo_101((info == null) ? default(HandleRef) : info.GetCppThis(), arrayType, numComponents);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetReleaseDataFlag_102(HandleRef pThis, int arg0);

		public void SetReleaseDataFlag(int arg0)
		{
			vtkDataObject.vtkDataObject_SetReleaseDataFlag_102(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetRequestExactExtent_103(HandleRef pThis, int flag);

		public virtual void SetRequestExactExtent(int flag)
		{
			vtkDataObject.vtkDataObject_SetRequestExactExtent_103(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetSource_104(HandleRef pThis, HandleRef s);

		public void SetSource(vtkSource s)
		{
			vtkDataObject.vtkDataObject_SetSource_104(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateExtent_105(HandleRef pThis, int piece, int numPieces, int ghostLevel);

		public virtual void SetUpdateExtent(int piece, int numPieces, int ghostLevel)
		{
			vtkDataObject.vtkDataObject_SetUpdateExtent_105(base.GetCppThis(), piece, numPieces, ghostLevel);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateExtent_106(HandleRef pThis, int piece, int numPieces);

		public void SetUpdateExtent(int piece, int numPieces)
		{
			vtkDataObject.vtkDataObject_SetUpdateExtent_106(base.GetCppThis(), piece, numPieces);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateExtent_107(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		public virtual void SetUpdateExtent(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkDataObject.vtkDataObject_SetUpdateExtent_107(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateExtent_108(HandleRef pThis, IntPtr extent);

		public virtual void SetUpdateExtent(IntPtr extent)
		{
			vtkDataObject.vtkDataObject_SetUpdateExtent_108(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateExtentToWholeExtent_109(HandleRef pThis);

		public void SetUpdateExtentToWholeExtent()
		{
			vtkDataObject.vtkDataObject_SetUpdateExtentToWholeExtent_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateGhostLevel_110(HandleRef pThis, int level);

		public void SetUpdateGhostLevel(int level)
		{
			vtkDataObject.vtkDataObject_SetUpdateGhostLevel_110(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdateNumberOfPieces_111(HandleRef pThis, int num);

		public void SetUpdateNumberOfPieces(int num)
		{
			vtkDataObject.vtkDataObject_SetUpdateNumberOfPieces_111(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetUpdatePiece_112(HandleRef pThis, int piece);

		public void SetUpdatePiece(int piece)
		{
			vtkDataObject.vtkDataObject_SetUpdatePiece_112(base.GetCppThis(), piece);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetWholeBoundingBox_113(HandleRef pThis, double x0, double x1, double y0, double y1, double z0, double z1);

		public virtual void SetWholeBoundingBox(double x0, double x1, double y0, double y1, double z0, double z1)
		{
			vtkDataObject.vtkDataObject_SetWholeBoundingBox_113(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetWholeBoundingBox_114(HandleRef pThis, IntPtr bb);

		public virtual void SetWholeBoundingBox(IntPtr bb)
		{
			vtkDataObject.vtkDataObject_SetWholeBoundingBox_114(base.GetCppThis(), bb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetWholeExtent_115(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		public virtual void SetWholeExtent(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkDataObject.vtkDataObject_SetWholeExtent_115(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_SetWholeExtent_116(HandleRef pThis, IntPtr extent);

		public virtual void SetWholeExtent(IntPtr extent)
		{
			vtkDataObject.vtkDataObject_SetWholeExtent_116(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_ShallowCopy_117(HandleRef pThis, HandleRef src);

		public virtual void ShallowCopy(vtkDataObject src)
		{
			vtkDataObject.vtkDataObject_ShallowCopy_117(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObject_ShouldIReleaseData_118(HandleRef pThis);

		public int ShouldIReleaseData()
		{
			return vtkDataObject.vtkDataObject_ShouldIReleaseData_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_TriggerAsynchronousUpdate_119(HandleRef pThis);

		public virtual void TriggerAsynchronousUpdate()
		{
			vtkDataObject.vtkDataObject_TriggerAsynchronousUpdate_119(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_Update_121(HandleRef pThis);

		public virtual void Update()
		{
			vtkDataObject.vtkDataObject_Update_121(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_UpdateData_122(HandleRef pThis);

		public virtual void UpdateData()
		{
			vtkDataObject.vtkDataObject_UpdateData_122(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataObject_UpdateInformation_123(HandleRef pThis);

		public virtual void UpdateInformation()
		{
			vtkDataObject.vtkDataObject_UpdateInformation_123(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObject_VERTEX_DATA_VECTOR_124(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey VERTEX_DATA_VECTOR()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObject.vtkDataObject_VERTEX_DATA_VECTOR_124(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}
	}
}
