using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkParametricFunction : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFunction";

		public new static readonly string MRClassNameKey;

		static vtkParametricFunction()
		{
			vtkParametricFunction.MRClassNameKey = "class vtkParametricFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFunction"));
		}

		public vtkParametricFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_ClockwiseOrderingOff_01(HandleRef pThis);

		public virtual void ClockwiseOrderingOff()
		{
			vtkParametricFunction.vtkParametricFunction_ClockwiseOrderingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_ClockwiseOrderingOn_02(HandleRef pThis);

		public virtual void ClockwiseOrderingOn()
		{
			vtkParametricFunction.vtkParametricFunction_ClockwiseOrderingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_DerivativesAvailableOff_03(HandleRef pThis);

		public virtual void DerivativesAvailableOff()
		{
			vtkParametricFunction.vtkParametricFunction_DerivativesAvailableOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_DerivativesAvailableOn_04(HandleRef pThis);

		public virtual void DerivativesAvailableOn()
		{
			vtkParametricFunction.vtkParametricFunction_DerivativesAvailableOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_Evaluate_05(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public virtual void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricFunction.vtkParametricFunction_Evaluate_05(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_EvaluateScalar_06(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public virtual double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricFunction.vtkParametricFunction_EvaluateScalar_06(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetClockwiseOrdering_07(HandleRef pThis);

		public virtual int GetClockwiseOrdering()
		{
			return vtkParametricFunction.vtkParametricFunction_GetClockwiseOrdering_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetDerivativesAvailable_08(HandleRef pThis);

		public virtual int GetDerivativesAvailable()
		{
			return vtkParametricFunction.vtkParametricFunction_GetDerivativesAvailable_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetDimension_09(HandleRef pThis);

		public virtual int GetDimension()
		{
			return vtkParametricFunction.vtkParametricFunction_GetDimension_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetJoinU_10(HandleRef pThis);

		public virtual int GetJoinU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinU_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetJoinV_11(HandleRef pThis);

		public virtual int GetJoinV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetJoinV_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_GetMaximumU_12(HandleRef pThis);

		public virtual double GetMaximumU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMaximumU_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_GetMaximumV_13(HandleRef pThis);

		public virtual double GetMaximumV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMaximumV_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_GetMaximumW_14(HandleRef pThis);

		public virtual double GetMaximumW()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMaximumW_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_GetMinimumU_15(HandleRef pThis);

		public virtual double GetMinimumU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMinimumU_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_GetMinimumV_16(HandleRef pThis);

		public virtual double GetMinimumV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMinimumV_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFunction_GetMinimumW_17(HandleRef pThis);

		public virtual double GetMinimumW()
		{
			return vtkParametricFunction.vtkParametricFunction_GetMinimumW_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetTwistU_18(HandleRef pThis);

		public virtual int GetTwistU()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistU_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_GetTwistV_19(HandleRef pThis);

		public virtual int GetTwistV()
		{
			return vtkParametricFunction.vtkParametricFunction_GetTwistV_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricFunction.vtkParametricFunction_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFunction_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricFunction.vtkParametricFunction_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_JoinUOff_22(HandleRef pThis);

		public virtual void JoinUOff()
		{
			vtkParametricFunction.vtkParametricFunction_JoinUOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_JoinUOn_23(HandleRef pThis);

		public virtual void JoinUOn()
		{
			vtkParametricFunction.vtkParametricFunction_JoinUOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_JoinVOff_24(HandleRef pThis);

		public virtual void JoinVOff()
		{
			vtkParametricFunction.vtkParametricFunction_JoinVOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_JoinVOn_25(HandleRef pThis);

		public virtual void JoinVOn()
		{
			vtkParametricFunction.vtkParametricFunction_JoinVOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFunction_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricFunction NewInstance()
		{
			vtkParametricFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFunction.vtkParametricFunction_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFunction_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricFunction SafeDownCast(vtkObjectBase o)
		{
			vtkParametricFunction vtkParametricFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFunction.vtkParametricFunction_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunction = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunction.Register(null);
				}
			}
			return vtkParametricFunction;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetClockwiseOrdering_28(HandleRef pThis, int _arg);

		public virtual void SetClockwiseOrdering(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetClockwiseOrdering_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetDerivativesAvailable_29(HandleRef pThis, int _arg);

		public virtual void SetDerivativesAvailable(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetDerivativesAvailable_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetJoinU_30(HandleRef pThis, int _arg);

		public virtual void SetJoinU(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetJoinU_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetJoinV_31(HandleRef pThis, int _arg);

		public virtual void SetJoinV(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetJoinV_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetMaximumU_32(HandleRef pThis, double _arg);

		public virtual void SetMaximumU(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMaximumU_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetMaximumV_33(HandleRef pThis, double _arg);

		public virtual void SetMaximumV(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMaximumV_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetMaximumW_34(HandleRef pThis, double _arg);

		public virtual void SetMaximumW(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMaximumW_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetMinimumU_35(HandleRef pThis, double _arg);

		public virtual void SetMinimumU(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMinimumU_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetMinimumV_36(HandleRef pThis, double _arg);

		public virtual void SetMinimumV(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMinimumV_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetMinimumW_37(HandleRef pThis, double _arg);

		public virtual void SetMinimumW(double _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetMinimumW_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetTwistU_38(HandleRef pThis, int _arg);

		public virtual void SetTwistU(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetTwistU_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_SetTwistV_39(HandleRef pThis, int _arg);

		public virtual void SetTwistV(int _arg)
		{
			vtkParametricFunction.vtkParametricFunction_SetTwistV_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_TwistUOff_40(HandleRef pThis);

		public virtual void TwistUOff()
		{
			vtkParametricFunction.vtkParametricFunction_TwistUOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_TwistUOn_41(HandleRef pThis);

		public virtual void TwistUOn()
		{
			vtkParametricFunction.vtkParametricFunction_TwistUOn_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_TwistVOff_42(HandleRef pThis);

		public virtual void TwistVOff()
		{
			vtkParametricFunction.vtkParametricFunction_TwistVOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFunction_TwistVOn_43(HandleRef pThis);

		public virtual void TwistVOn()
		{
			vtkParametricFunction.vtkParametricFunction_TwistVOn_43(base.GetCppThis());
		}
	}
}
