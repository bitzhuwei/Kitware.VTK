using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkShepardMethod : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShepardMethod";

		public new static readonly string MRClassNameKey;

		static vtkShepardMethod()
		{
			vtkShepardMethod.MRClassNameKey = "class vtkShepardMethod";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShepardMethod.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShepardMethod"));
		}

		public vtkShepardMethod(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkShepardMethod_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShepardMethod New()
		{
			vtkShepardMethod result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkShepardMethod() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkShepardMethod.vtkShepardMethod_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkShepardMethod_ComputeModelBounds_01(HandleRef pThis, IntPtr origin, IntPtr ar);

		public double ComputeModelBounds(IntPtr origin, IntPtr ar)
		{
			return vtkShepardMethod.vtkShepardMethod_ComputeModelBounds_01(base.GetCppThis(), origin, ar);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkShepardMethod_GetMaximumDistance_02(HandleRef pThis);

		public virtual double GetMaximumDistance()
		{
			return vtkShepardMethod.vtkShepardMethod_GetMaximumDistance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkShepardMethod_GetMaximumDistanceMaxValue_03(HandleRef pThis);

		public virtual double GetMaximumDistanceMaxValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetMaximumDistanceMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkShepardMethod_GetMaximumDistanceMinValue_04(HandleRef pThis);

		public virtual double GetMaximumDistanceMinValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetMaximumDistanceMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkShepardMethod_GetModelBounds_05(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_GetModelBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_GetModelBounds_06(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkShepardMethod.vtkShepardMethod_GetModelBounds_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkShepardMethod_GetNullValue_07(HandleRef pThis);

		public virtual double GetNullValue()
		{
			return vtkShepardMethod.vtkShepardMethod_GetNullValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkShepardMethod_GetSampleDimensions_08(HandleRef pThis);

		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_GetSampleDimensions_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_GetSampleDimensions_09(HandleRef pThis, IntPtr data);

		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkShepardMethod.vtkShepardMethod_GetSampleDimensions_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkShepardMethod_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShepardMethod.vtkShepardMethod_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkShepardMethod_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShepardMethod.vtkShepardMethod_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkShepardMethod_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShepardMethod NewInstance()
		{
			vtkShepardMethod result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkShepardMethod_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShepardMethod SafeDownCast(vtkObjectBase o)
		{
			vtkShepardMethod vtkShepardMethod = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShepardMethod.vtkShepardMethod_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShepardMethod = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShepardMethod.Register(null);
				}
			}
			return vtkShepardMethod;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_SetMaximumDistance_15(HandleRef pThis, double _arg);

		public virtual void SetMaximumDistance(double _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetMaximumDistance_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_SetModelBounds_16(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkShepardMethod.vtkShepardMethod_SetModelBounds_16(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_SetModelBounds_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetModelBounds_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_SetNullValue_18(HandleRef pThis, double _arg);

		public virtual void SetNullValue(double _arg)
		{
			vtkShepardMethod.vtkShepardMethod_SetNullValue_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_SetSampleDimensions_19(HandleRef pThis, int i, int j, int k);

		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkShepardMethod.vtkShepardMethod_SetSampleDimensions_19(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkShepardMethod_SetSampleDimensions_20(HandleRef pThis, IntPtr dim);

		public void SetSampleDimensions(IntPtr dim)
		{
			vtkShepardMethod.vtkShepardMethod_SetSampleDimensions_20(base.GetCppThis(), dim);
		}
	}
}
