using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCutMaterial : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCutMaterial";

		public new static readonly string MRClassNameKey;

		static vtkCutMaterial()
		{
			vtkCutMaterial.MRClassNameKey = "class vtkCutMaterial";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCutMaterial.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCutMaterial"));
		}

		public vtkCutMaterial(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCutMaterial New()
		{
			vtkCutMaterial result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCutMaterial() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCutMaterial.vtkCutMaterial_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_GetArrayName_01(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkCutMaterial.vtkCutMaterial_GetArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_GetCenterPoint_02(HandleRef pThis);

		public virtual double[] GetCenterPoint()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetCenterPoint_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetCenterPoint_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCenterPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetCenterPoint_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetCenterPoint_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenterPoint(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetCenterPoint_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCutMaterial_GetMaterial_05(HandleRef pThis);

		public virtual int GetMaterial()
		{
			return vtkCutMaterial.vtkCutMaterial_GetMaterial_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_GetMaterialArrayName_06(HandleRef pThis);

		public virtual string GetMaterialArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkCutMaterial.vtkCutMaterial_GetMaterialArrayName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_GetMaximumPoint_07(HandleRef pThis);

		public virtual double[] GetMaximumPoint()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetMaximumPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetMaximumPoint_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMaximumPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetMaximumPoint_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetMaximumPoint_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetMaximumPoint(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetMaximumPoint_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_GetNormal_10(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetNormal_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetNormal_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetNormal_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetNormal_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetNormal(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetNormal_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_GetUpVector_13(HandleRef pThis);

		public virtual double[] GetUpVector()
		{
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_GetUpVector_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetUpVector_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_GetUpVector_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_GetUpVector_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetUpVector(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_GetUpVector_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCutMaterial_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCutMaterial.vtkCutMaterial_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCutMaterial_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCutMaterial.vtkCutMaterial_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCutMaterial NewInstance()
		{
			vtkCutMaterial result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCutMaterial_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCutMaterial SafeDownCast(vtkObjectBase o)
		{
			vtkCutMaterial vtkCutMaterial = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCutMaterial.vtkCutMaterial_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCutMaterial = (vtkCutMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCutMaterial.Register(null);
				}
			}
			return vtkCutMaterial;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_SetArrayName_21(HandleRef pThis, string _arg);

		public virtual void SetArrayName(string _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetArrayName_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_SetMaterial_22(HandleRef pThis, int _arg);

		public virtual void SetMaterial(int _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetMaterial_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_SetMaterialArrayName_23(HandleRef pThis, string _arg);

		public virtual void SetMaterialArrayName(string _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetMaterialArrayName_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_SetUpVector_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetUpVector(double _arg1, double _arg2, double _arg3)
		{
			vtkCutMaterial.vtkCutMaterial_SetUpVector_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCutMaterial_SetUpVector_25(HandleRef pThis, IntPtr _arg);

		public virtual void SetUpVector(IntPtr _arg)
		{
			vtkCutMaterial.vtkCutMaterial_SetUpVector_25(base.GetCppThis(), _arg);
		}
	}
}
