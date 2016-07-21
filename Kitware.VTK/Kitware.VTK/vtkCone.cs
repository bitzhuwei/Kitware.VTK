using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCone : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCone";

		public new static readonly string MRClassNameKey;

		static vtkCone()
		{
			vtkCone.MRClassNameKey = "class vtkCone";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCone.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCone"));
		}

		public vtkCone(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCone_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCone New()
		{
			vtkCone result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCone.vtkCone_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCone)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCone() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCone.vtkCone_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCone_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkCone.vtkCone_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCone_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkCone.vtkCone_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCone_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkCone.vtkCone_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCone_GetAngle_04(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkCone.vtkCone_GetAngle_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCone_GetAngleMaxValue_05(HandleRef pThis);

		public virtual double GetAngleMaxValue()
		{
			return vtkCone.vtkCone_GetAngleMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCone_GetAngleMinValue_06(HandleRef pThis);

		public virtual double GetAngleMinValue()
		{
			return vtkCone.vtkCone_GetAngleMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCone_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCone.vtkCone_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCone_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCone.vtkCone_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCone_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCone NewInstance()
		{
			vtkCone result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCone.vtkCone_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCone)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCone_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCone SafeDownCast(vtkObjectBase o)
		{
			vtkCone vtkCone = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCone.vtkCone_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCone = (vtkCone)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCone.Register(null);
				}
			}
			return vtkCone;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCone_SetAngle_12(HandleRef pThis, double _arg);

		public virtual void SetAngle(double _arg)
		{
			vtkCone.vtkCone_SetAngle_12(base.GetCppThis(), _arg);
		}
	}
}
