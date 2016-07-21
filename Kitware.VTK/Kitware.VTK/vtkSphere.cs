using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphere : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphere";

		public new static readonly string MRClassNameKey;

		static vtkSphere()
		{
			vtkSphere.MRClassNameKey = "class vtkSphere";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphere.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphere"));
		}

		public vtkSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphere New()
		{
			vtkSphere result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphere.vtkSphere_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphere() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphere.vtkSphere_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSphere_ComputeBoundingSphere_01(IntPtr pts, long numPts, IntPtr sphere, IntPtr hints);

		public static void ComputeBoundingSphere(IntPtr pts, long numPts, IntPtr sphere, IntPtr hints)
		{
			vtkSphere.vtkSphere_ComputeBoundingSphere_01(pts, numPts, sphere, hints);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSphere_EvaluateFunction_02(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkSphere.vtkSphere_EvaluateFunction_02(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSphere_EvaluateFunction_03(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkSphere.vtkSphere_EvaluateFunction_03(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSphere_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkSphere.vtkSphere_EvaluateGradient_04(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphere_GetCenter_05(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSphere.vtkSphere_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSphere_GetCenter_06(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkSphere.vtkSphere_GetCenter_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSphere_GetRadius_07(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkSphere.vtkSphere_GetRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSphere_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphere.vtkSphere_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSphere_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphere.vtkSphere_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphere_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphere NewInstance()
		{
			vtkSphere result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphere.vtkSphere_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSphere_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphere SafeDownCast(vtkObjectBase o)
		{
			vtkSphere vtkSphere = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphere.vtkSphere_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphere = (vtkSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphere.Register(null);
				}
			}
			return vtkSphere;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSphere_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSphere.vtkSphere_SetCenter_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSphere_SetCenter_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSphere.vtkSphere_SetCenter_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSphere_SetRadius_15(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkSphere.vtkSphere_SetRadius_15(base.GetCppThis(), _arg);
		}
	}
}
