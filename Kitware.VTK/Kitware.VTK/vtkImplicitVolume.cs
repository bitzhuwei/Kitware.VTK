using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitVolume : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitVolume";

		public new static readonly string MRClassNameKey;

		static vtkImplicitVolume()
		{
			vtkImplicitVolume.MRClassNameKey = "class vtkImplicitVolume";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitVolume"));
		}

		public vtkImplicitVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitVolume New()
		{
			vtkImplicitVolume result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitVolume.vtkImplicitVolume_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitVolume_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitVolume.vtkImplicitVolume_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitVolume_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitVolume.vtkImplicitVolume_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitVolume.vtkImplicitVolume_EvaluateGradient_03(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImplicitVolume_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitVolume.vtkImplicitVolume_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitVolume_GetOutGradient_05(HandleRef pThis);

		public virtual double[] GetOutGradient()
		{
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_GetOutGradient_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_GetOutGradient_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutGradient(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitVolume.vtkImplicitVolume_GetOutGradient_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_GetOutGradient_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutGradient(IntPtr _arg)
		{
			vtkImplicitVolume.vtkImplicitVolume_GetOutGradient_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitVolume_GetOutValue_08(HandleRef pThis);

		public virtual double GetOutValue()
		{
			return vtkImplicitVolume.vtkImplicitVolume_GetOutValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitVolume_GetVolume_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetVolume()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_GetVolume_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitVolume_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitVolume.vtkImplicitVolume_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitVolume_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitVolume.vtkImplicitVolume_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitVolume_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitVolume NewInstance()
		{
			vtkImplicitVolume result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitVolume_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitVolume SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitVolume vtkImplicitVolume = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitVolume.vtkImplicitVolume_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitVolume = (vtkImplicitVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitVolume.Register(null);
				}
			}
			return vtkImplicitVolume;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_SetOutGradient_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutGradient(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetOutGradient_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_SetOutGradient_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutGradient(IntPtr _arg)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetOutGradient_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_SetOutValue_17(HandleRef pThis, double _arg);

		public virtual void SetOutValue(double _arg)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetOutValue_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitVolume_SetVolume_18(HandleRef pThis, HandleRef arg0);

		public virtual void SetVolume(vtkImageData arg0)
		{
			vtkImplicitVolume.vtkImplicitVolume_SetVolume_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
