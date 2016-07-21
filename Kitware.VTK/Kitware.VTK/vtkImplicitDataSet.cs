using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitDataSet : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitDataSet";

		public new static readonly string MRClassNameKey;

		static vtkImplicitDataSet()
		{
			vtkImplicitDataSet.MRClassNameKey = "class vtkImplicitDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitDataSet"));
		}

		public vtkImplicitDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitDataSet New()
		{
			vtkImplicitDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitDataSet.vtkImplicitDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitDataSet_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitDataSet_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_EvaluateGradient_03(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitDataSet_GetDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_GetDataSet_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImplicitDataSet_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitDataSet_GetOutGradient_06(HandleRef pThis);

		public virtual double[] GetOutGradient()
		{
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_GetOutGradient_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_GetOutGradient_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutGradient(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_GetOutGradient_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_GetOutGradient_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutGradient(IntPtr _arg)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_GetOutGradient_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitDataSet_GetOutValue_09(HandleRef pThis);

		public virtual double GetOutValue()
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_GetOutValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitDataSet_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitDataSet_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitDataSet_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitDataSet NewInstance()
		{
			vtkImplicitDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitDataSet_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitDataSet vtkImplicitDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitDataSet = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitDataSet.Register(null);
				}
			}
			return vtkImplicitDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_SetDataSet_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetDataSet_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_SetOutGradient_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutGradient(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetOutGradient_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_SetOutGradient_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutGradient(IntPtr _arg)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetOutGradient_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitDataSet_SetOutValue_18(HandleRef pThis, double _arg);

		public virtual void SetOutValue(double _arg)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetOutValue_18(base.GetCppThis(), _arg);
		}
	}
}
