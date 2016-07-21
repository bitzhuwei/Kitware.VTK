using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricFigure8Klein : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFigure8Klein";

		public new static readonly string MRClassNameKey;

		static vtkParametricFigure8Klein()
		{
			vtkParametricFigure8Klein.MRClassNameKey = "class vtkParametricFigure8Klein";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricFigure8Klein.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFigure8Klein"));
		}

		public vtkParametricFigure8Klein(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFigure8Klein_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricFigure8Klein New()
		{
			vtkParametricFigure8Klein result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFigure8Klein.vtkParametricFigure8Klein_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricFigure8Klein() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricFigure8Klein.vtkParametricFigure8Klein_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFigure8Klein_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricFigure8Klein.vtkParametricFigure8Klein_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFigure8Klein_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFigure8Klein_GetDimension_03(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_GetDimension_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricFigure8Klein_GetRadius_04(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_GetRadius_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFigure8Klein_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricFigure8Klein_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricFigure8Klein.vtkParametricFigure8Klein_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFigure8Klein_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricFigure8Klein NewInstance()
		{
			vtkParametricFigure8Klein result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFigure8Klein.vtkParametricFigure8Klein_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFigure8Klein_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricFigure8Klein SafeDownCast(vtkObjectBase o)
		{
			vtkParametricFigure8Klein vtkParametricFigure8Klein = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFigure8Klein.vtkParametricFigure8Klein_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFigure8Klein = (vtkParametricFigure8Klein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFigure8Klein.Register(null);
				}
			}
			return vtkParametricFigure8Klein;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricFigure8Klein_SetRadius_10(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkParametricFigure8Klein.vtkParametricFigure8Klein_SetRadius_10(base.GetCppThis(), _arg);
		}
	}
}
