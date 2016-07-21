using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricKlein : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricKlein";

		public new static readonly string MRClassNameKey;

		static vtkParametricKlein()
		{
			vtkParametricKlein.MRClassNameKey = "class vtkParametricKlein";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricKlein.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricKlein"));
		}

		public vtkParametricKlein(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricKlein_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricKlein New()
		{
			vtkParametricKlein result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricKlein.vtkParametricKlein_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricKlein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricKlein() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricKlein.vtkParametricKlein_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricKlein_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricKlein.vtkParametricKlein_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricKlein_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricKlein.vtkParametricKlein_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricKlein_GetDimension_03(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricKlein.vtkParametricKlein_GetDimension_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricKlein_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricKlein.vtkParametricKlein_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricKlein_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricKlein.vtkParametricKlein_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricKlein_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricKlein NewInstance()
		{
			vtkParametricKlein result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricKlein.vtkParametricKlein_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricKlein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricKlein_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricKlein SafeDownCast(vtkObjectBase o)
		{
			vtkParametricKlein vtkParametricKlein = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricKlein.vtkParametricKlein_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricKlein = (vtkParametricKlein)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricKlein.Register(null);
				}
			}
			return vtkParametricKlein;
		}
	}
}
