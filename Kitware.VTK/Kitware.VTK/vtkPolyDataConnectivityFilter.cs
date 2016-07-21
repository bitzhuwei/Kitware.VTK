using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataConnectivityFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataConnectivityFilter";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataConnectivityFilter()
		{
			vtkPolyDataConnectivityFilter.MRClassNameKey = "class vtkPolyDataConnectivityFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataConnectivityFilter"));
		}

		public vtkPolyDataConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataConnectivityFilter New()
		{
			vtkPolyDataConnectivityFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_AddSeed_01(HandleRef pThis, int id);

		public void AddSeed(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_AddSeed_01(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

		public void AddSpecifiedRegion(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_AddSpecifiedRegion_02(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_ColorRegionsOff_03(HandleRef pThis);

		public virtual void ColorRegionsOff()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ColorRegionsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_ColorRegionsOn_04(HandleRef pThis);

		public virtual void ColorRegionsOn()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ColorRegionsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_DeleteSeed_05(HandleRef pThis, int id);

		public void DeleteSeed(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_DeleteSeed_05(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_DeleteSpecifiedRegion_06(HandleRef pThis, int id);

		public void DeleteSpecifiedRegion(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_DeleteSpecifiedRegion_06(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetClosestPoint_07(HandleRef pThis);

		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetClosestPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_GetClosestPoint_08(HandleRef pThis, IntPtr data);

		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetClosestPoint_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_GetColorRegions_09(HandleRef pThis);

		public virtual int GetColorRegions()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetColorRegions_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_GetExtractionMode_10(HandleRef pThis);

		public virtual int GetExtractionMode()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetExtractionModeAsString_11(HandleRef pThis);

		public string GetExtractionModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionModeAsString_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_GetExtractionModeMaxValue_12(HandleRef pThis);

		public virtual int GetExtractionModeMaxValue()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionModeMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_GetExtractionModeMinValue_13(HandleRef pThis);

		public virtual int GetExtractionModeMinValue()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionModeMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_GetNumberOfExtractedRegions_14(HandleRef pThis);

		public int GetNumberOfExtractedRegions()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetNumberOfExtractedRegions_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_GetScalarConnectivity_15(HandleRef pThis);

		public virtual int GetScalarConnectivity()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarConnectivity_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetScalarRange_16(HandleRef pThis);

		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarRange_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_GetScalarRange_17(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarRange_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_GetScalarRange_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarRange_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_InitializeSeedList_19(HandleRef pThis);

		public void InitializeSeedList()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_InitializeSeedList_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_InitializeSpecifiedRegionList_20(HandleRef pThis);

		public void InitializeSpecifiedRegionList()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_InitializeSpecifiedRegionList_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataConnectivityFilter_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataConnectivityFilter NewInstance()
		{
			vtkPolyDataConnectivityFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataConnectivityFilter vtkPolyDataConnectivityFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataConnectivityFilter = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataConnectivityFilter.Register(null);
				}
			}
			return vtkPolyDataConnectivityFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_ScalarConnectivityOff_26(HandleRef pThis);

		public virtual void ScalarConnectivityOff()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ScalarConnectivityOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_ScalarConnectivityOn_27(HandleRef pThis);

		public virtual void ScalarConnectivityOn()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ScalarConnectivityOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetClosestPoint_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetClosestPoint_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetClosestPoint_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetClosestPoint_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetColorRegions_30(HandleRef pThis, int _arg);

		public virtual void SetColorRegions(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetColorRegions_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionMode_31(HandleRef pThis, int _arg);

		public virtual void SetExtractionMode(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionMode_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToAllRegions_32(HandleRef pThis);

		public void SetExtractionModeToAllRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToAllRegions_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToCellSeededRegions_33(HandleRef pThis);

		public void SetExtractionModeToCellSeededRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToCellSeededRegions_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToClosestPointRegion_34(HandleRef pThis);

		public void SetExtractionModeToClosestPointRegion()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToClosestPointRegion_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToLargestRegion_35(HandleRef pThis);

		public void SetExtractionModeToLargestRegion()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToLargestRegion_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToPointSeededRegions_36(HandleRef pThis);

		public void SetExtractionModeToPointSeededRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToPointSeededRegions_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToSpecifiedRegions_37(HandleRef pThis);

		public void SetExtractionModeToSpecifiedRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToSpecifiedRegions_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetScalarConnectivity_38(HandleRef pThis, int _arg);

		public virtual void SetScalarConnectivity(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetScalarConnectivity_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetScalarRange_39(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetScalarRange_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataConnectivityFilter_SetScalarRange_40(HandleRef pThis, IntPtr _arg);

		public void SetScalarRange(IntPtr _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetScalarRange_40(base.GetCppThis(), _arg);
		}
	}
}
