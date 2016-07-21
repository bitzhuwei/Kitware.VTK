using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricDini : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricDini";

		public new static readonly string MRClassNameKey;

		static vtkParametricDini()
		{
			vtkParametricDini.MRClassNameKey = "class vtkParametricDini";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricDini.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricDini"));
		}

		public vtkParametricDini(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricDini_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricDini New()
		{
			vtkParametricDini result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricDini.vtkParametricDini_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricDini)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricDini() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricDini.vtkParametricDini_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricDini_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricDini.vtkParametricDini_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricDini_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricDini.vtkParametricDini_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricDini_GetA_03(HandleRef pThis);

		public virtual double GetA()
		{
			return vtkParametricDini.vtkParametricDini_GetA_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricDini_GetB_04(HandleRef pThis);

		public virtual double GetB()
		{
			return vtkParametricDini.vtkParametricDini_GetB_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricDini_GetDimension_05(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricDini.vtkParametricDini_GetDimension_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricDini_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricDini.vtkParametricDini_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricDini_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricDini.vtkParametricDini_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricDini_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricDini NewInstance()
		{
			vtkParametricDini result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricDini.vtkParametricDini_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricDini)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricDini_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricDini SafeDownCast(vtkObjectBase o)
		{
			vtkParametricDini vtkParametricDini = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricDini.vtkParametricDini_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricDini = (vtkParametricDini)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricDini.Register(null);
				}
			}
			return vtkParametricDini;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricDini_SetA_11(HandleRef pThis, double _arg);

		public virtual void SetA(double _arg)
		{
			vtkParametricDini.vtkParametricDini_SetA_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricDini_SetB_12(HandleRef pThis, double _arg);

		public virtual void SetB(double _arg)
		{
			vtkParametricDini.vtkParametricDini_SetB_12(base.GetCppThis(), _arg);
		}
	}
}
