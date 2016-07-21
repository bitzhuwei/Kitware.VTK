using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricConicSpiral : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricConicSpiral";

		public new static readonly string MRClassNameKey;

		static vtkParametricConicSpiral()
		{
			vtkParametricConicSpiral.MRClassNameKey = "class vtkParametricConicSpiral";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricConicSpiral.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricConicSpiral"));
		}

		public vtkParametricConicSpiral(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricConicSpiral_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricConicSpiral New()
		{
			vtkParametricConicSpiral result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricConicSpiral.vtkParametricConicSpiral_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricConicSpiral() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricConicSpiral.vtkParametricConicSpiral_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricConicSpiral_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricConicSpiral_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricConicSpiral_GetA_03(HandleRef pThis);

		public virtual double GetA()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetA_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricConicSpiral_GetB_04(HandleRef pThis);

		public virtual double GetB()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetB_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricConicSpiral_GetC_05(HandleRef pThis);

		public virtual double GetC()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetC_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricConicSpiral_GetDimension_06(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetDimension_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricConicSpiral_GetN_07(HandleRef pThis);

		public virtual double GetN()
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_GetN_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricConicSpiral_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricConicSpiral_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricConicSpiral.vtkParametricConicSpiral_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricConicSpiral_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricConicSpiral NewInstance()
		{
			vtkParametricConicSpiral result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricConicSpiral.vtkParametricConicSpiral_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricConicSpiral_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricConicSpiral SafeDownCast(vtkObjectBase o)
		{
			vtkParametricConicSpiral vtkParametricConicSpiral = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricConicSpiral.vtkParametricConicSpiral_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricConicSpiral = (vtkParametricConicSpiral)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricConicSpiral.Register(null);
				}
			}
			return vtkParametricConicSpiral;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricConicSpiral_SetA_13(HandleRef pThis, double _arg);

		public virtual void SetA(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetA_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricConicSpiral_SetB_14(HandleRef pThis, double _arg);

		public virtual void SetB(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetB_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricConicSpiral_SetC_15(HandleRef pThis, double _arg);

		public virtual void SetC(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetC_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricConicSpiral_SetN_16(HandleRef pThis, double _arg);

		public virtual void SetN(double _arg)
		{
			vtkParametricConicSpiral.vtkParametricConicSpiral_SetN_16(base.GetCppThis(), _arg);
		}
	}
}
