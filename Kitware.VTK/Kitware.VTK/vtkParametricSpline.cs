using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricSpline : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSpline";

		public new static readonly string MRClassNameKey;

		static vtkParametricSpline()
		{
			vtkParametricSpline.MRClassNameKey = "class vtkParametricSpline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSpline"));
		}

		public vtkParametricSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricSpline New()
		{
			vtkParametricSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricSpline.vtkParametricSpline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_ClosedOff_01(HandleRef pThis);

		public virtual void ClosedOff()
		{
			vtkParametricSpline.vtkParametricSpline_ClosedOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_ClosedOn_02(HandleRef pThis);

		public virtual void ClosedOn()
		{
			vtkParametricSpline.vtkParametricSpline_ClosedOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_Evaluate_03(HandleRef pThis, IntPtr u, IntPtr Pt, IntPtr Du);

		public override void Evaluate(IntPtr u, IntPtr Pt, IntPtr Du)
		{
			vtkParametricSpline.vtkParametricSpline_Evaluate_03(base.GetCppThis(), u, Pt, Du);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkParametricSpline_EvaluateScalar_04(HandleRef pThis, IntPtr u, IntPtr Pt, IntPtr Du);

		public override double EvaluateScalar(IntPtr u, IntPtr Pt, IntPtr Du)
		{
			return vtkParametricSpline.vtkParametricSpline_EvaluateScalar_04(base.GetCppThis(), u, Pt, Du);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetClosed_05(HandleRef pThis);

		public virtual int GetClosed()
		{
			return vtkParametricSpline.vtkParametricSpline_GetClosed_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetDimension_06(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricSpline.vtkParametricSpline_GetDimension_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetLeftConstraint_07(HandleRef pThis);

		public virtual int GetLeftConstraint()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftConstraint_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetLeftConstraintMaxValue_08(HandleRef pThis);

		public virtual int GetLeftConstraintMaxValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftConstraintMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetLeftConstraintMinValue_09(HandleRef pThis);

		public virtual int GetLeftConstraintMinValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftConstraintMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkParametricSpline_GetLeftValue_10(HandleRef pThis);

		public virtual double GetLeftValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetLeftValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetParameterizeByLength_11(HandleRef pThis);

		public virtual int GetParameterizeByLength()
		{
			return vtkParametricSpline.vtkParametricSpline_GetParameterizeByLength_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSpline_GetPoints_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetPoints_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetRightConstraint_13(HandleRef pThis);

		public virtual int GetRightConstraint()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightConstraint_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetRightConstraintMaxValue_14(HandleRef pThis);

		public virtual int GetRightConstraintMaxValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightConstraintMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_GetRightConstraintMinValue_15(HandleRef pThis);

		public virtual int GetRightConstraintMinValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightConstraintMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkParametricSpline_GetRightValue_16(HandleRef pThis);

		public virtual double GetRightValue()
		{
			return vtkParametricSpline.vtkParametricSpline_GetRightValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSpline_GetXSpline_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSpline GetXSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetXSpline_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkParametricSpline_GetYSpline_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSpline GetYSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetYSpline_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkParametricSpline_GetZSpline_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSpline GetZSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_GetZSpline_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkParametricSpline_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricSpline.vtkParametricSpline_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkParametricSpline_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricSpline.vtkParametricSpline_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSpline_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricSpline NewInstance()
		{
			vtkParametricSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_ParameterizeByLengthOff_24(HandleRef pThis);

		public virtual void ParameterizeByLengthOff()
		{
			vtkParametricSpline.vtkParametricSpline_ParameterizeByLengthOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_ParameterizeByLengthOn_25(HandleRef pThis);

		public virtual void ParameterizeByLengthOn()
		{
			vtkParametricSpline.vtkParametricSpline_ParameterizeByLengthOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSpline_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricSpline SafeDownCast(vtkObjectBase o)
		{
			vtkParametricSpline vtkParametricSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSpline.vtkParametricSpline_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSpline = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSpline.Register(null);
				}
			}
			return vtkParametricSpline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetClosed_27(HandleRef pThis, int _arg);

		public virtual void SetClosed(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetClosed_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetLeftConstraint_28(HandleRef pThis, int _arg);

		public virtual void SetLeftConstraint(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetLeftConstraint_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetLeftValue_29(HandleRef pThis, double _arg);

		public virtual void SetLeftValue(double _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetLeftValue_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetNumberOfPoints_30(HandleRef pThis, long numPts);

		public void SetNumberOfPoints(long numPts)
		{
			vtkParametricSpline.vtkParametricSpline_SetNumberOfPoints_30(base.GetCppThis(), numPts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetParameterizeByLength_31(HandleRef pThis, int _arg);

		public virtual void SetParameterizeByLength(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetParameterizeByLength_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetPoint_32(HandleRef pThis, long index, double x, double y, double z);

		public void SetPoint(long index, double x, double y, double z)
		{
			vtkParametricSpline.vtkParametricSpline_SetPoint_32(base.GetCppThis(), index, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetPoints_33(HandleRef pThis, HandleRef arg0);

		public void SetPoints(vtkPoints arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetPoints_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetRightConstraint_34(HandleRef pThis, int _arg);

		public virtual void SetRightConstraint(int _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetRightConstraint_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetRightValue_35(HandleRef pThis, double _arg);

		public virtual void SetRightValue(double _arg)
		{
			vtkParametricSpline.vtkParametricSpline_SetRightValue_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetXSpline_36(HandleRef pThis, HandleRef arg0);

		public void SetXSpline(vtkSpline arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetXSpline_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetYSpline_37(HandleRef pThis, HandleRef arg0);

		public void SetYSpline(vtkSpline arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetYSpline_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkParametricSpline_SetZSpline_38(HandleRef pThis, HandleRef arg0);

		public void SetZSpline(vtkSpline arg0)
		{
			vtkParametricSpline.vtkParametricSpline_SetZSpline_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
