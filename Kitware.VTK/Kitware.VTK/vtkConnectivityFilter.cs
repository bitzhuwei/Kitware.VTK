using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConnectivityFilter : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConnectivityFilter";

		public new static readonly string MRClassNameKey;

		static vtkConnectivityFilter()
		{
			vtkConnectivityFilter.MRClassNameKey = "class vtkConnectivityFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConnectivityFilter"));
		}

		public vtkConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConnectivityFilter New()
		{
			vtkConnectivityFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConnectivityFilter.vtkConnectivityFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_AddSeed_01(HandleRef pThis, long id);

		public void AddSeed(long id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_AddSeed_01(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

		public void AddSpecifiedRegion(int id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_AddSpecifiedRegion_02(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_ColorRegionsOff_03(HandleRef pThis);

		public virtual void ColorRegionsOff()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ColorRegionsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_ColorRegionsOn_04(HandleRef pThis);

		public virtual void ColorRegionsOn()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ColorRegionsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_DeleteSeed_05(HandleRef pThis, long id);

		public void DeleteSeed(long id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_DeleteSeed_05(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_DeleteSpecifiedRegion_06(HandleRef pThis, int id);

		public void DeleteSpecifiedRegion(int id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_DeleteSpecifiedRegion_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConnectivityFilter_GetClosestPoint_07(HandleRef pThis);

		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_GetClosestPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_GetClosestPoint_08(HandleRef pThis, IntPtr data);

		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_GetClosestPoint_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_GetColorRegions_09(HandleRef pThis);

		public virtual int GetColorRegions()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetColorRegions_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_GetExtractionMode_10(HandleRef pThis);

		public virtual int GetExtractionMode()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConnectivityFilter_GetExtractionModeAsString_11(HandleRef pThis);

		public string GetExtractionModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionModeAsString_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_GetExtractionModeMaxValue_12(HandleRef pThis);

		public virtual int GetExtractionModeMaxValue()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionModeMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_GetExtractionModeMinValue_13(HandleRef pThis);

		public virtual int GetExtractionModeMinValue()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionModeMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_GetNumberOfExtractedRegions_14(HandleRef pThis);

		public int GetNumberOfExtractedRegions()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetNumberOfExtractedRegions_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_GetScalarConnectivity_15(HandleRef pThis);

		public virtual int GetScalarConnectivity()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetScalarConnectivity_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConnectivityFilter_GetScalarRange_16(HandleRef pThis);

		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_GetScalarRange_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_GetScalarRange_17(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_GetScalarRange_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_GetScalarRange_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_GetScalarRange_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_InitializeSeedList_19(HandleRef pThis);

		public void InitializeSeedList()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_InitializeSeedList_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_InitializeSpecifiedRegionList_20(HandleRef pThis);

		public void InitializeSpecifiedRegionList()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_InitializeSpecifiedRegionList_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConnectivityFilter_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConnectivityFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConnectivityFilter NewInstance()
		{
			vtkConnectivityFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConnectivityFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkConnectivityFilter vtkConnectivityFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConnectivityFilter = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConnectivityFilter.Register(null);
				}
			}
			return vtkConnectivityFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_ScalarConnectivityOff_26(HandleRef pThis);

		public virtual void ScalarConnectivityOff()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ScalarConnectivityOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_ScalarConnectivityOn_27(HandleRef pThis);

		public virtual void ScalarConnectivityOn()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ScalarConnectivityOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetClosestPoint_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetClosestPoint_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetClosestPoint_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetClosestPoint_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetColorRegions_30(HandleRef pThis, int _arg);

		public virtual void SetColorRegions(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetColorRegions_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionMode_31(HandleRef pThis, int _arg);

		public virtual void SetExtractionMode(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionMode_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToAllRegions_32(HandleRef pThis);

		public void SetExtractionModeToAllRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToAllRegions_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToCellSeededRegions_33(HandleRef pThis);

		public void SetExtractionModeToCellSeededRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToCellSeededRegions_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToClosestPointRegion_34(HandleRef pThis);

		public void SetExtractionModeToClosestPointRegion()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToClosestPointRegion_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToLargestRegion_35(HandleRef pThis);

		public void SetExtractionModeToLargestRegion()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToLargestRegion_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToPointSeededRegions_36(HandleRef pThis);

		public void SetExtractionModeToPointSeededRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToPointSeededRegions_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToSpecifiedRegions_37(HandleRef pThis);

		public void SetExtractionModeToSpecifiedRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToSpecifiedRegions_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetScalarConnectivity_38(HandleRef pThis, int _arg);

		public virtual void SetScalarConnectivity(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetScalarConnectivity_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetScalarRange_39(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetScalarRange_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConnectivityFilter_SetScalarRange_40(HandleRef pThis, IntPtr _arg);

		public void SetScalarRange(IntPtr _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetScalarRange_40(base.GetCppThis(), _arg);
		}
	}
}
