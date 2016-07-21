using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelCoordinatesHistogramRepresentation : vtkParallelCoordinatesRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesHistogramRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkParallelCoordinatesHistogramRepresentation()
		{
			vtkParallelCoordinatesHistogramRepresentation.MRClassNameKey = "class vtkParallelCoordinatesHistogramRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesHistogramRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesHistogramRepresentation"));
		}

		public vtkParallelCoordinatesHistogramRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesHistogramRepresentation New()
		{
			vtkParallelCoordinatesHistogramRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelCoordinatesHistogramRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_02(HandleRef pThis);

		public virtual double[] GetHistogramLookupTableRange()
		{
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_03(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetHistogramLookupTableRange(ref double _arg1, ref double _arg2)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_03(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetHistogramLookupTableRange(IntPtr _arg)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_05(HandleRef pThis);

		public virtual int[] GetNumberOfHistogramBins()
		{
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetNumberOfHistogramBins(ref int _arg1, ref int _arg2)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetNumberOfHistogramBins(IntPtr _arg)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetPreferredNumberOfOutliers_08(HandleRef pThis);

		public virtual int GetPreferredNumberOfOutliers()
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetPreferredNumberOfOutliers_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetShowOutliers_09(HandleRef pThis);

		public virtual int GetShowOutliers()
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetShowOutliers_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetUseHistograms_10(HandleRef pThis);

		public virtual int GetUseHistograms()
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_GetUseHistograms_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelCoordinatesHistogramRepresentation NewInstance()
		{
			vtkParallelCoordinatesHistogramRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesHistogramRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesHistogramRepresentation vtkParallelCoordinatesHistogramRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesHistogramRepresentation = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesHistogramRepresentation.Register(null);
				}
			}
			return vtkParallelCoordinatesHistogramRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_16(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetHistogramLookupTableRange(double _arg1, double _arg2)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_16(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_17(HandleRef pThis, IntPtr _arg);

		public void SetHistogramLookupTableRange(IntPtr _arg)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_18(HandleRef pThis, int arg0, int arg1);

		public void SetNumberOfHistogramBins(int arg0, int arg1)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_18(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_19(HandleRef pThis, IntPtr arg0);

		public void SetNumberOfHistogramBins(IntPtr arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_19(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetPreferredNumberOfOutliers_20(HandleRef pThis, int arg0);

		public void SetPreferredNumberOfOutliers(int arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetPreferredNumberOfOutliers_20(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_SetRangeAtPosition_21(HandleRef pThis, int position, IntPtr range);

		public override int SetRangeAtPosition(int position, IntPtr range)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetRangeAtPosition_21(base.GetCppThis(), position, range);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetShowOutliers_22(HandleRef pThis, int arg0);

		public virtual void SetShowOutliers(int arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetShowOutliers_22(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetUseHistograms_23(HandleRef pThis, int arg0);

		public virtual void SetUseHistograms(int arg0)
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SetUseHistograms_23(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOff_24(HandleRef pThis);

		public virtual void ShowOutliersOff()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOn_25(HandleRef pThis);

		public virtual void ShowOutliersOn()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesHistogramRepresentation_SwapAxisPositions_26(HandleRef pThis, int position1, int position2);

		public override int SwapAxisPositions(int position1, int position2)
		{
			return vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_SwapAxisPositions_26(base.GetCppThis(), position1, position2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOff_27(HandleRef pThis);

		public virtual void UseHistogramsOff()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOn_28(HandleRef pThis);

		public virtual void UseHistogramsOn()
		{
			vtkParallelCoordinatesHistogramRepresentation.vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOn_28(base.GetCppThis());
		}
	}
}
