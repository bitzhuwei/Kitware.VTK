using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkSpline : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpline";

		public new static readonly string MRClassNameKey;

		static vtkSpline()
		{
			vtkSpline.MRClassNameKey = "class vtkSpline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpline"));
		}

		public vtkSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_AddPoint_01(HandleRef pThis, double t, double x);

		public void AddPoint(double t, double x)
		{
			vtkSpline.vtkSpline_AddPoint_01(base.GetCppThis(), t, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_ClampValueOff_02(HandleRef pThis);

		public virtual void ClampValueOff()
		{
			vtkSpline.vtkSpline_ClampValueOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_ClampValueOn_03(HandleRef pThis);

		public virtual void ClampValueOn()
		{
			vtkSpline.vtkSpline_ClampValueOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_ClosedOff_04(HandleRef pThis);

		public virtual void ClosedOff()
		{
			vtkSpline.vtkSpline_ClosedOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_ClosedOn_05(HandleRef pThis);

		public virtual void ClosedOn()
		{
			vtkSpline.vtkSpline_ClosedOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_Compute_06(HandleRef pThis);

		public virtual void Compute()
		{
			vtkSpline.vtkSpline_Compute_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_DeepCopy_07(HandleRef pThis, HandleRef s);

		public virtual void DeepCopy(vtkSpline s)
		{
			vtkSpline.vtkSpline_DeepCopy_07(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSpline_Evaluate_08(HandleRef pThis, double t);

		public virtual double Evaluate(double t)
		{
			return vtkSpline.vtkSpline_Evaluate_08(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetClampValue_09(HandleRef pThis);

		public virtual int GetClampValue()
		{
			return vtkSpline.vtkSpline_GetClampValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetClosed_10(HandleRef pThis);

		public virtual int GetClosed()
		{
			return vtkSpline.vtkSpline_GetClosed_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetLeftConstraint_11(HandleRef pThis);

		public virtual int GetLeftConstraint()
		{
			return vtkSpline.vtkSpline_GetLeftConstraint_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetLeftConstraintMaxValue_12(HandleRef pThis);

		public virtual int GetLeftConstraintMaxValue()
		{
			return vtkSpline.vtkSpline_GetLeftConstraintMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetLeftConstraintMinValue_13(HandleRef pThis);

		public virtual int GetLeftConstraintMinValue()
		{
			return vtkSpline.vtkSpline_GetLeftConstraintMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSpline_GetLeftValue_14(HandleRef pThis);

		public virtual double GetLeftValue()
		{
			return vtkSpline.vtkSpline_GetLeftValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkSpline_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSpline.vtkSpline_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetNumberOfPoints_16(HandleRef pThis);

		public int GetNumberOfPoints()
		{
			return vtkSpline.vtkSpline_GetNumberOfPoints_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_GetParametricRange_17(HandleRef pThis, IntPtr tRange);

		public void GetParametricRange(IntPtr tRange)
		{
			vtkSpline.vtkSpline_GetParametricRange_17(base.GetCppThis(), tRange);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetRightConstraint_18(HandleRef pThis);

		public virtual int GetRightConstraint()
		{
			return vtkSpline.vtkSpline_GetRightConstraint_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetRightConstraintMaxValue_19(HandleRef pThis);

		public virtual int GetRightConstraintMaxValue()
		{
			return vtkSpline.vtkSpline_GetRightConstraintMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_GetRightConstraintMinValue_20(HandleRef pThis);

		public virtual int GetRightConstraintMinValue()
		{
			return vtkSpline.vtkSpline_GetRightConstraintMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSpline_GetRightValue_21(HandleRef pThis);

		public virtual double GetRightValue()
		{
			return vtkSpline.vtkSpline_GetRightValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSpline.vtkSpline_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSpline_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSpline.vtkSpline_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSpline_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSpline NewInstance()
		{
			vtkSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpline.vtkSpline_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_RemoveAllPoints_25(HandleRef pThis);

		public void RemoveAllPoints()
		{
			vtkSpline.vtkSpline_RemoveAllPoints_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_RemovePoint_26(HandleRef pThis, double t);

		public void RemovePoint(double t)
		{
			vtkSpline.vtkSpline_RemovePoint_26(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSpline_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpline SafeDownCast(vtkObjectBase o)
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpline.vtkSpline_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetClampValue_28(HandleRef pThis, int _arg);

		public virtual void SetClampValue(int _arg)
		{
			vtkSpline.vtkSpline_SetClampValue_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetClosed_29(HandleRef pThis, int _arg);

		public virtual void SetClosed(int _arg)
		{
			vtkSpline.vtkSpline_SetClosed_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetLeftConstraint_30(HandleRef pThis, int _arg);

		public virtual void SetLeftConstraint(int _arg)
		{
			vtkSpline.vtkSpline_SetLeftConstraint_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetLeftValue_31(HandleRef pThis, double _arg);

		public virtual void SetLeftValue(double _arg)
		{
			vtkSpline.vtkSpline_SetLeftValue_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetParametricRange_32(HandleRef pThis, double tMin, double tMax);

		public void SetParametricRange(double tMin, double tMax)
		{
			vtkSpline.vtkSpline_SetParametricRange_32(base.GetCppThis(), tMin, tMax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetParametricRange_33(HandleRef pThis, IntPtr tRange);

		public void SetParametricRange(IntPtr tRange)
		{
			vtkSpline.vtkSpline_SetParametricRange_33(base.GetCppThis(), tRange);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetRightConstraint_34(HandleRef pThis, int _arg);

		public virtual void SetRightConstraint(int _arg)
		{
			vtkSpline.vtkSpline_SetRightConstraint_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSpline_SetRightValue_35(HandleRef pThis, double _arg);

		public virtual void SetRightValue(double _arg)
		{
			vtkSpline.vtkSpline_SetRightValue_35(base.GetCppThis(), _arg);
		}
	}
}
