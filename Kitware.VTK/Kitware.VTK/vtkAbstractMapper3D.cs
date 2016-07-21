using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractMapper3D : vtkAbstractMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractMapper3D";

		public new static readonly string MRClassNameKey;

		static vtkAbstractMapper3D()
		{
			vtkAbstractMapper3D.MRClassNameKey = "class vtkAbstractMapper3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractMapper3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractMapper3D"));
		}

		public vtkAbstractMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper3D_GetBounds_01(HandleRef pThis);

		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper3D_GetBounds_02(HandleRef pThis, IntPtr bounds);

		public virtual void GetBounds(IntPtr bounds)
		{
			vtkAbstractMapper3D.vtkAbstractMapper3D_GetBounds_02(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper3D_GetCenter_03(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper3D_GetCenter_04(HandleRef pThis, IntPtr center);

		public void GetCenter(IntPtr center)
		{
			vtkAbstractMapper3D.vtkAbstractMapper3D_GetCenter_04(base.GetCppThis(), center);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAbstractMapper3D_GetLength_05(HandleRef pThis);

		public double GetLength()
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_GetLength_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractMapper3D_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractMapper3D_IsARayCastMapper_07(HandleRef pThis);

		public virtual int IsARayCastMapper()
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsARayCastMapper_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractMapper3D_IsARenderIntoImageMapper_08(HandleRef pThis);

		public virtual int IsARenderIntoImageMapper()
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsARenderIntoImageMapper_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractMapper3D_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper3D_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractMapper3D NewInstance()
		{
			vtkAbstractMapper3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper3D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractMapper3D SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}
	}
}
