using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKochanekSpline : vtkSpline
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKochanekSpline";

		public new static readonly string MRClassNameKey;

		static vtkKochanekSpline()
		{
			vtkKochanekSpline.MRClassNameKey = "class vtkKochanekSpline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKochanekSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKochanekSpline"));
		}

		public vtkKochanekSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKochanekSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKochanekSpline New()
		{
			vtkKochanekSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKochanekSpline.vtkKochanekSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKochanekSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKochanekSpline.vtkKochanekSpline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKochanekSpline_Compute_01(HandleRef pThis);

		public override void Compute()
		{
			vtkKochanekSpline.vtkKochanekSpline_Compute_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKochanekSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

		public override void DeepCopy(vtkSpline s)
		{
			vtkKochanekSpline.vtkKochanekSpline_DeepCopy_02(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKochanekSpline_Evaluate_03(HandleRef pThis, double t);

		public override double Evaluate(double t)
		{
			return vtkKochanekSpline.vtkKochanekSpline_Evaluate_03(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKochanekSpline_GetDefaultBias_04(HandleRef pThis);

		public virtual double GetDefaultBias()
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetDefaultBias_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKochanekSpline_GetDefaultContinuity_05(HandleRef pThis);

		public virtual double GetDefaultContinuity()
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetDefaultContinuity_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKochanekSpline_GetDefaultTension_06(HandleRef pThis);

		public virtual double GetDefaultTension()
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetDefaultTension_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKochanekSpline_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKochanekSpline.vtkKochanekSpline_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKochanekSpline_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKochanekSpline.vtkKochanekSpline_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKochanekSpline_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKochanekSpline NewInstance()
		{
			vtkKochanekSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKochanekSpline.vtkKochanekSpline_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKochanekSpline_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKochanekSpline SafeDownCast(vtkObjectBase o)
		{
			vtkKochanekSpline vtkKochanekSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKochanekSpline.vtkKochanekSpline_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKochanekSpline = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKochanekSpline.Register(null);
				}
			}
			return vtkKochanekSpline;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKochanekSpline_SetDefaultBias_12(HandleRef pThis, double _arg);

		public virtual void SetDefaultBias(double _arg)
		{
			vtkKochanekSpline.vtkKochanekSpline_SetDefaultBias_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKochanekSpline_SetDefaultContinuity_13(HandleRef pThis, double _arg);

		public virtual void SetDefaultContinuity(double _arg)
		{
			vtkKochanekSpline.vtkKochanekSpline_SetDefaultContinuity_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKochanekSpline_SetDefaultTension_14(HandleRef pThis, double _arg);

		public virtual void SetDefaultTension(double _arg)
		{
			vtkKochanekSpline.vtkKochanekSpline_SetDefaultTension_14(base.GetCppThis(), _arg);
		}
	}
}
