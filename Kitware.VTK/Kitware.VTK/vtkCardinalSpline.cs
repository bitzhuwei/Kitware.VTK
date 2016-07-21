using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCardinalSpline : vtkSpline
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCardinalSpline";

		public new static readonly string MRClassNameKey;

		static vtkCardinalSpline()
		{
			vtkCardinalSpline.MRClassNameKey = "class vtkCardinalSpline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCardinalSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCardinalSpline"));
		}

		public vtkCardinalSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCardinalSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCardinalSpline New()
		{
			vtkCardinalSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCardinalSpline.vtkCardinalSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCardinalSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCardinalSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCardinalSpline.vtkCardinalSpline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCardinalSpline_Compute_01(HandleRef pThis);

		public override void Compute()
		{
			vtkCardinalSpline.vtkCardinalSpline_Compute_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCardinalSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

		public override void DeepCopy(vtkSpline s)
		{
			vtkCardinalSpline.vtkCardinalSpline_DeepCopy_02(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCardinalSpline_Evaluate_03(HandleRef pThis, double t);

		public override double Evaluate(double t)
		{
			return vtkCardinalSpline.vtkCardinalSpline_Evaluate_03(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCardinalSpline_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCardinalSpline.vtkCardinalSpline_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCardinalSpline_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCardinalSpline.vtkCardinalSpline_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCardinalSpline_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCardinalSpline NewInstance()
		{
			vtkCardinalSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCardinalSpline.vtkCardinalSpline_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCardinalSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCardinalSpline_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCardinalSpline SafeDownCast(vtkObjectBase o)
		{
			vtkCardinalSpline vtkCardinalSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCardinalSpline.vtkCardinalSpline_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCardinalSpline = (vtkCardinalSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCardinalSpline.Register(null);
				}
			}
			return vtkCardinalSpline;
		}
	}
}
