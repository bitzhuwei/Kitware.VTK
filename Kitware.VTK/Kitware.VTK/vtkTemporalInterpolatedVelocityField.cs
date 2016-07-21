using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalInterpolatedVelocityField : vtkFunctionSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalInterpolatedVelocityField";

		public new static readonly string MRClassNameKey;

		static vtkTemporalInterpolatedVelocityField()
		{
			vtkTemporalInterpolatedVelocityField.MRClassNameKey = "class vtkTemporalInterpolatedVelocityField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalInterpolatedVelocityField"));
		}

		public vtkTemporalInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalInterpolatedVelocityField New()
		{
			vtkTemporalInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_AdvanceOneTimeStep_01(HandleRef pThis);

		public void AdvanceOneTimeStep()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_AdvanceOneTimeStep_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_ClearCache_02(HandleRef pThis);

		public void ClearCache()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_ClearCache_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr u);

		public override int FunctionValues(IntPtr x, IntPtr u)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_FunctionValues_03(base.GetCppThis(), x, u);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolatedVelocityField_FunctionValuesAtT_04(HandleRef pThis, int T, IntPtr x, IntPtr u);

		public int FunctionValuesAtT(int T, IntPtr x, IntPtr u)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_FunctionValuesAtT_04(base.GetCppThis(), T, x, u);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkTemporalInterpolatedVelocityField_GetCachedCellIds_05(HandleRef pThis, IntPtr id, IntPtr ds);

		public bool GetCachedCellIds(IntPtr id, IntPtr ds)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetCachedCellIds_05(base.GetCppThis(), id, ds) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkTemporalInterpolatedVelocityField_GetCurrentWeight_06(HandleRef pThis);

		public virtual double GetCurrentWeight()
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetCurrentWeight_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_07(HandleRef pThis);

		public virtual double[] GetLastGoodVelocity()
		{
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetLastGoodVelocity(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetLastGoodVelocity(IntPtr _arg)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkTemporalInterpolatedVelocityField_GetVorticityData_10(HandleRef pThis, int T, IntPtr pcoords, IntPtr weights, HandleRef cell, HandleRef cellVectors);

		public bool GetVorticityData(int T, IntPtr pcoords, IntPtr weights, vtkGenericCell cell, vtkDoubleArray cellVectors)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetVorticityData_10(base.GetCppThis(), T, pcoords, weights, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (cellVectors == null) ? default(HandleRef) : cellVectors.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkTemporalInterpolatedVelocityField_InterpolatePoint_11(HandleRef pThis, HandleRef outPD1, HandleRef outPD2, long outIndex);

		public bool InterpolatePoint(vtkPointData outPD1, vtkPointData outPD2, long outIndex)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_InterpolatePoint_11(base.GetCppThis(), (outPD1 == null) ? default(HandleRef) : outPD1.GetCppThis(), (outPD2 == null) ? default(HandleRef) : outPD2.GetCppThis(), outIndex) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkTemporalInterpolatedVelocityField_InterpolatePoint_12(HandleRef pThis, int T, HandleRef outPD1, long outIndex);

		public bool InterpolatePoint(int T, vtkPointData outPD1, long outIndex)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_InterpolatePoint_12(base.GetCppThis(), T, (outPD1 == null) ? default(HandleRef) : outPD1.GetCppThis(), outIndex) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolatedVelocityField_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkTemporalInterpolatedVelocityField_IsStatic_14(HandleRef pThis, int datasetIndex);

		public bool IsStatic(int datasetIndex)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_IsStatic_14(base.GetCppThis(), datasetIndex) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolatedVelocityField_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalInterpolatedVelocityField NewInstance()
		{
			vtkTemporalInterpolatedVelocityField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolatedVelocityField_QuickTestPoint_18(HandleRef pThis, IntPtr x);

		public int QuickTestPoint(IntPtr x)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_QuickTestPoint_18(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalInterpolatedVelocityField vtkTemporalInterpolatedVelocityField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalInterpolatedVelocityField = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalInterpolatedVelocityField.Register(null);
				}
			}
			return vtkTemporalInterpolatedVelocityField;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_SelectVectors_20(HandleRef pThis, string fieldName);

		public void SelectVectors(string fieldName)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SelectVectors_20(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetCachedCellIds_21(HandleRef pThis, IntPtr id, IntPtr ds);

		public void SetCachedCellIds(IntPtr id, IntPtr ds)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetCachedCellIds_21(base.GetCppThis(), id, ds);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetDataSetAtTime_22(HandleRef pThis, int I, int N, double T, HandleRef dataset, byte staticdataset);

		public void SetDataSetAtTime(int I, int N, double T, vtkDataSet dataset, bool staticdataset)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetDataSetAtTime_22(base.GetCppThis(), I, N, T, (dataset == null) ? default(HandleRef) : dataset.GetCppThis(), staticdataset ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolatedVelocityField_ShowCacheResults_23(HandleRef pThis);

		public void ShowCacheResults()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_ShowCacheResults_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolatedVelocityField_TestPoint_24(HandleRef pThis, IntPtr x);

		public int TestPoint(IntPtr x)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_TestPoint_24(base.GetCppThis(), x);
		}
	}
}
