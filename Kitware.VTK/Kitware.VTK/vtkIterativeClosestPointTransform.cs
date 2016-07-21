using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIterativeClosestPointTransform : vtkLinearTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIterativeClosestPointTransform";

		public new static readonly string MRClassNameKey;

		static vtkIterativeClosestPointTransform()
		{
			vtkIterativeClosestPointTransform.MRClassNameKey = "class vtkIterativeClosestPointTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIterativeClosestPointTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIterativeClosestPointTransform"));
		}

		public vtkIterativeClosestPointTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIterativeClosestPointTransform New()
		{
			vtkIterativeClosestPointTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIterativeClosestPointTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_CheckMeanDistanceOff_01(HandleRef pThis);

		public virtual void CheckMeanDistanceOff()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_CheckMeanDistanceOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_CheckMeanDistanceOn_02(HandleRef pThis);

		public virtual void CheckMeanDistanceOn()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_CheckMeanDistanceOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetCheckMeanDistance_03(HandleRef pThis);

		public virtual int GetCheckMeanDistance()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetCheckMeanDistance_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetLandmarkTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLandmarkTransform GetLandmarkTransform()
		{
			vtkLandmarkTransform vtkLandmarkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetLandmarkTransform_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLandmarkTransform = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLandmarkTransform.Register(null);
				}
			}
			return vtkLandmarkTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCellLocator GetLocator()
		{
			vtkCellLocator vtkCellLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetLocator_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocator = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocator.Register(null);
				}
			}
			return vtkCellLocator;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkIterativeClosestPointTransform_GetMaximumMeanDistance_06(HandleRef pThis);

		public virtual double GetMaximumMeanDistance()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMaximumMeanDistance_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetMaximumNumberOfIterations_07(HandleRef pThis);

		public virtual int GetMaximumNumberOfIterations()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMaximumNumberOfIterations_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetMaximumNumberOfLandmarks_08(HandleRef pThis);

		public virtual int GetMaximumNumberOfLandmarks()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMaximumNumberOfLandmarks_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkIterativeClosestPointTransform_GetMeanDistance_09(HandleRef pThis);

		public virtual double GetMeanDistance()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistance_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceMode_10(HandleRef pThis);

		public virtual int GetMeanDistanceMode()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetMeanDistanceModeAsString_11(HandleRef pThis);

		public string GetMeanDistanceModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceModeAsString_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceModeMaxValue_12(HandleRef pThis);

		public virtual int GetMeanDistanceModeMaxValue()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceModeMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetMeanDistanceModeMinValue_13(HandleRef pThis);

		public virtual int GetMeanDistanceModeMinValue()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetMeanDistanceModeMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetNumberOfIterations_14(HandleRef pThis);

		public virtual int GetNumberOfIterations()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetNumberOfIterations_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetSource_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_GetStartByMatchingCentroids_16(HandleRef pThis);

		public virtual int GetStartByMatchingCentroids()
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetStartByMatchingCentroids_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_GetTarget_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetTarget()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_GetTarget_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_Inverse_18(HandleRef pThis);

		public override void Inverse()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_Inverse_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkIterativeClosestPointTransform_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_MakeTransform_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_MakeTransform_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIterativeClosestPointTransform NewInstance()
		{
			vtkIterativeClosestPointTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkIterativeClosestPointTransform_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIterativeClosestPointTransform SafeDownCast(vtkObjectBase o)
		{
			vtkIterativeClosestPointTransform vtkIterativeClosestPointTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIterativeClosestPointTransform = (vtkIterativeClosestPointTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIterativeClosestPointTransform.Register(null);
				}
			}
			return vtkIterativeClosestPointTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetCheckMeanDistance_25(HandleRef pThis, int _arg);

		public virtual void SetCheckMeanDistance(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetCheckMeanDistance_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetLocator_26(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkCellLocator locator)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetLocator_26(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetMaximumMeanDistance_27(HandleRef pThis, double _arg);

		public virtual void SetMaximumMeanDistance(double _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMaximumMeanDistance_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetMaximumNumberOfIterations_28(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfIterations(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMaximumNumberOfIterations_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetMaximumNumberOfLandmarks_29(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfLandmarks(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMaximumNumberOfLandmarks_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceMode_30(HandleRef pThis, int _arg);

		public virtual void SetMeanDistanceMode(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMeanDistanceMode_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceModeToAbsoluteValue_31(HandleRef pThis);

		public void SetMeanDistanceModeToAbsoluteValue()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMeanDistanceModeToAbsoluteValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetMeanDistanceModeToRMS_32(HandleRef pThis);

		public void SetMeanDistanceModeToRMS()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetMeanDistanceModeToRMS_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetSource_33(HandleRef pThis, HandleRef source);

		public void SetSource(vtkDataSet source)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetSource_33(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetStartByMatchingCentroids_34(HandleRef pThis, int _arg);

		public virtual void SetStartByMatchingCentroids(int _arg)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetStartByMatchingCentroids_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_SetTarget_35(HandleRef pThis, HandleRef target);

		public void SetTarget(vtkDataSet target)
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_SetTarget_35(base.GetCppThis(), (target == null) ? default(HandleRef) : target.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_StartByMatchingCentroidsOff_36(HandleRef pThis);

		public virtual void StartByMatchingCentroidsOff()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_StartByMatchingCentroidsOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkIterativeClosestPointTransform_StartByMatchingCentroidsOn_37(HandleRef pThis);

		public virtual void StartByMatchingCentroidsOn()
		{
			vtkIterativeClosestPointTransform.vtkIterativeClosestPointTransform_StartByMatchingCentroidsOn_37(base.GetCppThis());
		}
	}
}
