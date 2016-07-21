using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSuperquadric : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSuperquadric";

		public new static readonly string MRClassNameKey;

		static vtkSuperquadric()
		{
			vtkSuperquadric.MRClassNameKey = "class vtkSuperquadric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSuperquadric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSuperquadric"));
		}

		public vtkSuperquadric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSuperquadric New()
		{
			vtkSuperquadric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSuperquadric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSuperquadric.vtkSuperquadric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkSuperquadric.vtkSuperquadric_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkSuperquadric.vtkSuperquadric_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkSuperquadric.vtkSuperquadric_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadric_GetCenter_04(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_GetCenter_05(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkSuperquadric.vtkSuperquadric_GetCenter_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_GetPhiRoundness_06(HandleRef pThis);

		public virtual double GetPhiRoundness()
		{
			return vtkSuperquadric.vtkSuperquadric_GetPhiRoundness_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadric_GetScale_07(HandleRef pThis);

		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_GetScale_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_GetScale_08(HandleRef pThis, IntPtr data);

		public virtual void GetScale(IntPtr data)
		{
			vtkSuperquadric.vtkSuperquadric_GetScale_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_GetSize_09(HandleRef pThis);

		public virtual double GetSize()
		{
			return vtkSuperquadric.vtkSuperquadric_GetSize_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_GetThetaRoundness_10(HandleRef pThis);

		public virtual double GetThetaRoundness()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThetaRoundness_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_GetThickness_11(HandleRef pThis);

		public virtual double GetThickness()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThickness_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_GetThicknessMaxValue_12(HandleRef pThis);

		public virtual double GetThicknessMaxValue()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThicknessMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSuperquadric_GetThicknessMinValue_13(HandleRef pThis);

		public virtual double GetThicknessMinValue()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThicknessMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSuperquadric_GetToroidal_14(HandleRef pThis);

		public virtual int GetToroidal()
		{
			return vtkSuperquadric.vtkSuperquadric_GetToroidal_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSuperquadric_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSuperquadric.vtkSuperquadric_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSuperquadric_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSuperquadric.vtkSuperquadric_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadric_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSuperquadric NewInstance()
		{
			vtkSuperquadric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSuperquadric_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSuperquadric SafeDownCast(vtkObjectBase o)
		{
			vtkSuperquadric vtkSuperquadric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSuperquadric = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSuperquadric.Register(null);
				}
			}
			return vtkSuperquadric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetCenter_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadric.vtkSuperquadric_SetCenter_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetCenter_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetCenter_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetPhiRoundness_22(HandleRef pThis, double e);

		public void SetPhiRoundness(double e)
		{
			vtkSuperquadric.vtkSuperquadric_SetPhiRoundness_22(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetScale_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadric.vtkSuperquadric_SetScale_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetScale_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetScale(IntPtr _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetScale_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetSize_25(HandleRef pThis, double _arg);

		public virtual void SetSize(double _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetSize_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetThetaRoundness_26(HandleRef pThis, double e);

		public void SetThetaRoundness(double e)
		{
			vtkSuperquadric.vtkSuperquadric_SetThetaRoundness_26(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetThickness_27(HandleRef pThis, double _arg);

		public virtual void SetThickness(double _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetThickness_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_SetToroidal_28(HandleRef pThis, int _arg);

		public virtual void SetToroidal(int _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetToroidal_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_ToroidalOff_29(HandleRef pThis);

		public virtual void ToroidalOff()
		{
			vtkSuperquadric.vtkSuperquadric_ToroidalOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSuperquadric_ToroidalOn_30(HandleRef pThis);

		public virtual void ToroidalOn()
		{
			vtkSuperquadric.vtkSuperquadric_ToroidalOn_30(base.GetCppThis());
		}
	}
}
