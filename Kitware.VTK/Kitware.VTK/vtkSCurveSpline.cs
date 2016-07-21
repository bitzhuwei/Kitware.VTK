using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSCurveSpline : vtkSpline
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSCurveSpline";

		public new static readonly string MRClassNameKey;

		static vtkSCurveSpline()
		{
			vtkSCurveSpline.MRClassNameKey = "class vtkSCurveSpline";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSCurveSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSCurveSpline"));
		}

		public vtkSCurveSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSCurveSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSCurveSpline New()
		{
			vtkSCurveSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSCurveSpline.vtkSCurveSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSCurveSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSCurveSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSCurveSpline.vtkSCurveSpline_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSCurveSpline_Compute_01(HandleRef pThis);

		public override void Compute()
		{
			vtkSCurveSpline.vtkSCurveSpline_Compute_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSCurveSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

		public override void DeepCopy(vtkSpline s)
		{
			vtkSCurveSpline.vtkSCurveSpline_DeepCopy_02(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSCurveSpline_Evaluate_03(HandleRef pThis, double t);

		public override double Evaluate(double t)
		{
			return vtkSCurveSpline.vtkSCurveSpline_Evaluate_03(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSCurveSpline_GetNodeWeight_04(HandleRef pThis);

		public virtual double GetNodeWeight()
		{
			return vtkSCurveSpline.vtkSCurveSpline_GetNodeWeight_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSCurveSpline_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSCurveSpline.vtkSCurveSpline_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSCurveSpline_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSCurveSpline.vtkSCurveSpline_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSCurveSpline_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSCurveSpline NewInstance()
		{
			vtkSCurveSpline result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSCurveSpline.vtkSCurveSpline_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSCurveSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSCurveSpline_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSCurveSpline SafeDownCast(vtkObjectBase o)
		{
			vtkSCurveSpline vtkSCurveSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSCurveSpline.vtkSCurveSpline_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSCurveSpline = (vtkSCurveSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSCurveSpline.Register(null);
				}
			}
			return vtkSCurveSpline;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSCurveSpline_SetNodeWeight_10(HandleRef pThis, double _arg);

		public virtual void SetNodeWeight(double _arg)
		{
			vtkSCurveSpline.vtkSCurveSpline_SetNodeWeight_10(base.GetCppThis(), _arg);
		}
	}
}
