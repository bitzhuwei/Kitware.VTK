using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamingDemandDrivenPipeline : vtkDemandDrivenPipeline
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamingDemandDrivenPipeline";

		public new static readonly string MRClassNameKey;

		static vtkStreamingDemandDrivenPipeline()
		{
			vtkStreamingDemandDrivenPipeline.MRClassNameKey = "class vtkStreamingDemandDrivenPipeline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamingDemandDrivenPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamingDemandDrivenPipeline"));
		}

		public vtkStreamingDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamingDemandDrivenPipeline New()
		{
			vtkStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamingDemandDrivenPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_COMBINED_UPDATE_EXTENT_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerVectorKey COMBINED_UPDATE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_COMBINED_UPDATE_EXTENT_01(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_CONTINUE_EXECUTING_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey CONTINUE_EXECUTING()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_CONTINUE_EXECUTING_02(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkStreamingDemandDrivenPipeline_ComputePriority_03(HandleRef pThis);

		public double ComputePriority()
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_ComputePriority_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkStreamingDemandDrivenPipeline_ComputePriority_04(HandleRef pThis, int port);

		public virtual double ComputePriority(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_ComputePriority_04(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_EXACT_EXTENT_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey EXACT_EXTENT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_EXACT_EXTENT_05(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_EXTENT_TRANSLATOR_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationObjectBaseKey EXTENT_TRANSLATOR()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_EXTENT_TRANSLATOR_06(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_FAST_PATH_FOR_TEMPORAL_DATA_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey FAST_PATH_FOR_TEMPORAL_DATA()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_FAST_PATH_FOR_TEMPORAL_DATA_07(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_FAST_PATH_ID_TYPE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey FAST_PATH_ID_TYPE()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_FAST_PATH_ID_TYPE_08(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_FAST_PATH_OBJECT_ID_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIdTypeKey FAST_PATH_OBJECT_ID()
		{
			vtkInformationIdTypeKey vtkInformationIdTypeKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_FAST_PATH_OBJECT_ID_09(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIdTypeKey = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIdTypeKey.Register(null);
				}
			}
			return vtkInformationIdTypeKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_FAST_PATH_OBJECT_TYPE_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey FAST_PATH_OBJECT_TYPE()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_FAST_PATH_OBJECT_TYPE_10(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetExtentTranslator_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExtentTranslator GetExtentTranslator(int port)
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetExtentTranslator_11(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetExtentTranslator_12(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExtentTranslator GetExtentTranslator(vtkInformation info)
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetExtentTranslator_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStreamingDemandDrivenPipeline_GetMaximumNumberOfPieces_13(HandleRef pThis, int port);

		public int GetMaximumNumberOfPieces(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetMaximumNumberOfPieces_13(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetMaximumNumberOfPieces_14(HandleRef pThis, HandleRef arg0);

		public int GetMaximumNumberOfPieces(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetMaximumNumberOfPieces_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStreamingDemandDrivenPipeline_GetPieceBoundingBox_15(HandleRef pThis, int port, IntPtr bb);

		public void GetPieceBoundingBox(int port, IntPtr bb)
		{
			vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetPieceBoundingBox_15(base.GetCppThis(), port, bb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetPieceBoundingBox_16(HandleRef pThis, int port);

		public IntPtr GetPieceBoundingBox(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetPieceBoundingBox_16(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetRequestExactExtent_17(HandleRef pThis, int port);

		public int GetRequestExactExtent(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetRequestExactExtent_17(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStreamingDemandDrivenPipeline_GetUpdateExtent_18(HandleRef pThis, HandleRef arg0, IntPtr extent);

		public void GetUpdateExtent(vtkInformation arg0, IntPtr extent)
		{
			vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateExtent_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetUpdateExtent_19(HandleRef pThis, HandleRef arg0);

		public IntPtr GetUpdateExtent(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateExtent_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdateGhostLevel_20(HandleRef pThis, HandleRef arg0);

		public int GetUpdateGhostLevel(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateGhostLevel_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdateNumberOfPieces_21(HandleRef pThis, HandleRef arg0);

		public int GetUpdateNumberOfPieces(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateNumberOfPieces_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdatePiece_22(HandleRef pThis, HandleRef arg0);

		public int GetUpdatePiece(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdatePiece_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkStreamingDemandDrivenPipeline_GetUpdateResolution_23(HandleRef pThis, HandleRef arg0);

		public double GetUpdateResolution(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateResolution_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStreamingDemandDrivenPipeline_GetWholeBoundingBox_24(HandleRef pThis, int port, IntPtr bb);

		public void GetWholeBoundingBox(int port, IntPtr bb)
		{
			vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetWholeBoundingBox_24(base.GetCppThis(), port, bb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetWholeBoundingBox_25(HandleRef pThis, int port);

		public IntPtr GetWholeBoundingBox(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetWholeBoundingBox_25(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStreamingDemandDrivenPipeline_GetWholeExtent_26(HandleRef pThis, HandleRef arg0, IntPtr extent);

		public void GetWholeExtent(vtkInformation arg0, IntPtr extent)
		{
			vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetWholeExtent_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetWholeExtent_27(HandleRef pThis, HandleRef arg0);

		public IntPtr GetWholeExtent(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetWholeExtent_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_MAXIMUM_NUMBER_OF_PIECES_30(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey MAXIMUM_NUMBER_OF_PIECES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_MAXIMUM_NUMBER_OF_PIECES_30(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamingDemandDrivenPipeline NewInstance()
		{
			vtkStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_PIECE_BOUNDING_BOX_33(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey PIECE_BOUNDING_BOX()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_PIECE_BOUNDING_BOX_33(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_PRIORITY_34(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleKey PRIORITY()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_PRIORITY_34(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStreamingDemandDrivenPipeline_PropagateUpdateExtent_35(HandleRef pThis, int outputPort);

		public int PropagateUpdateExtent(int outputPort)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_PropagateUpdateExtent_35(base.GetCppThis(), outputPort);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REMOVE_ATTRIBUTE_INFORMATION_36(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey REMOVE_ATTRIBUTE_INFORMATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REMOVE_ATTRIBUTE_INFORMATION_36(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_RESOLUTION_PROPAGATE_37(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_RESOLUTION_PROPAGATE()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REQUEST_RESOLUTION_PROPAGATE_37(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_38(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_UPDATE_EXTENT()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_38(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_INFORMATION_39(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationRequestKey REQUEST_UPDATE_EXTENT_INFORMATION()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_INFORMATION_39(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamingDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkStreamingDemandDrivenPipeline vtkStreamingDemandDrivenPipeline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamingDemandDrivenPipeline = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamingDemandDrivenPipeline.Register(null);
				}
			}
			return vtkStreamingDemandDrivenPipeline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetExtentTranslator_41(HandleRef pThis, int port, HandleRef translator);

		public int SetExtentTranslator(int port, vtkExtentTranslator translator)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetExtentTranslator_41(base.GetCppThis(), port, (translator == null) ? default(HandleRef) : translator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetExtentTranslator_42(HandleRef pThis, HandleRef arg0, HandleRef translator);

		public int SetExtentTranslator(vtkInformation arg0, vtkExtentTranslator translator)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetExtentTranslator_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (translator == null) ? default(HandleRef) : translator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetMaximumNumberOfPieces_43(HandleRef pThis, int port, int n);

		public int SetMaximumNumberOfPieces(int port, int n)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetMaximumNumberOfPieces_43(base.GetCppThis(), port, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetMaximumNumberOfPieces_44(HandleRef pThis, HandleRef arg0, int n);

		public int SetMaximumNumberOfPieces(vtkInformation arg0, int n)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetMaximumNumberOfPieces_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetPieceBoundingBox_45(HandleRef pThis, int port, IntPtr bb);

		public int SetPieceBoundingBox(int port, IntPtr bb)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetPieceBoundingBox_45(base.GetCppThis(), port, bb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetRequestExactExtent_46(HandleRef pThis, int port, int flag);

		public int SetRequestExactExtent(int port, int flag)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetRequestExactExtent_46(base.GetCppThis(), port, flag);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateExtent_47(HandleRef pThis, int port, IntPtr extent);

		public int SetUpdateExtent(int port, IntPtr extent)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateExtent_47(base.GetCppThis(), port, extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateExtent_48(HandleRef pThis, HandleRef arg0, IntPtr extent);

		public int SetUpdateExtent(vtkInformation arg0, IntPtr extent)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateExtent_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateExtent_49(HandleRef pThis, int port, int piece, int numPieces, int ghostLevel);

		public int SetUpdateExtent(int port, int piece, int numPieces, int ghostLevel)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateExtent_49(base.GetCppThis(), port, piece, numPieces, ghostLevel);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateExtent_50(HandleRef pThis, HandleRef arg0, int piece, int numPieces, int ghostLevel);

		public int SetUpdateExtent(vtkInformation arg0, int piece, int numPieces, int ghostLevel)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateExtent_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), piece, numPieces, ghostLevel);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateExtentToWholeExtent_51(HandleRef pThis, int port);

		public int SetUpdateExtentToWholeExtent(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateExtentToWholeExtent_51(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateExtentToWholeExtent_52(HandleRef pThis, HandleRef arg0);

		public int SetUpdateExtentToWholeExtent(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateExtentToWholeExtent_52(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateGhostLevel_53(HandleRef pThis, HandleRef arg0, int n);

		public int SetUpdateGhostLevel(vtkInformation arg0, int n)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateGhostLevel_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateNumberOfPieces_54(HandleRef pThis, HandleRef arg0, int n);

		public int SetUpdateNumberOfPieces(vtkInformation arg0, int n)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateNumberOfPieces_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdatePiece_55(HandleRef pThis, HandleRef arg0, int piece);

		public int SetUpdatePiece(vtkInformation arg0, int piece)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdatePiece_55(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), piece);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateResolution_56(HandleRef pThis, int port, double r);

		public int SetUpdateResolution(int port, double r)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateResolution_56(base.GetCppThis(), port, r);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateResolution_57(HandleRef pThis, HandleRef arg0, double r);

		public int SetUpdateResolution(vtkInformation arg0, double r)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateResolution_57(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateTimeStep_58(HandleRef pThis, int port, double time);

		public int SetUpdateTimeStep(int port, double time)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateTimeStep_58(base.GetCppThis(), port, time);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateTimeSteps_59(HandleRef pThis, int port, IntPtr times, int length);

		public int SetUpdateTimeSteps(int port, IntPtr times, int length)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateTimeSteps_59(base.GetCppThis(), port, times, length);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetUpdateTimeSteps_60(HandleRef pThis, HandleRef arg0, IntPtr times, int length);

		public int SetUpdateTimeSteps(vtkInformation arg0, IntPtr times, int length)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetUpdateTimeSteps_60(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), times, length);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetWholeBoundingBox_61(HandleRef pThis, int port, IntPtr bb);

		public int SetWholeBoundingBox(int port, IntPtr bb)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetWholeBoundingBox_61(base.GetCppThis(), port, bb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetWholeExtent_62(HandleRef pThis, HandleRef arg0, IntPtr extent);

		public int SetWholeExtent(vtkInformation arg0, IntPtr extent)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetWholeExtent_62(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_RANGE_63(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey TIME_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_TIME_RANGE_63(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_STEPS_64(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey TIME_STEPS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_TIME_STEPS_64(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UNRESTRICTED_UPDATE_EXTENT_65(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey UNRESTRICTED_UPDATE_EXTENT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UNRESTRICTED_UPDATE_EXTENT_65(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_66(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerVectorKey UPDATE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_66(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_INITIALIZED_67(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey UPDATE_EXTENT_INITIALIZED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_INITIALIZED_67(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_TRANSLATED_68(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey UPDATE_EXTENT_TRANSLATED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_TRANSLATED_68(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_GHOST_LEVELS_69(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey UPDATE_NUMBER_OF_GHOST_LEVELS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_GHOST_LEVELS_69(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_PIECES_70(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey UPDATE_NUMBER_OF_PIECES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_PIECES_70(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_PIECE_NUMBER_71(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey UPDATE_PIECE_NUMBER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_PIECE_NUMBER_71(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_RESOLUTION_72(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleKey UPDATE_RESOLUTION()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_RESOLUTION_72(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_TIME_STEPS_73(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey UPDATE_TIME_STEPS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_TIME_STEPS_73(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStreamingDemandDrivenPipeline_Update_74(HandleRef pThis);

		public override int Update()
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_Update_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_Update_75(HandleRef pThis, int port);

		public override int Update(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_Update_75(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStreamingDemandDrivenPipeline_UpdateWholeExtent_76(HandleRef pThis);

		public virtual int UpdateWholeExtent()
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UpdateWholeExtent_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_WHOLE_BOUNDING_BOX_77(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey WHOLE_BOUNDING_BOX()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_WHOLE_BOUNDING_BOX_77(ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_WHOLE_EXTENT_78(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerVectorKey WHOLE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_WHOLE_EXTENT_78(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
