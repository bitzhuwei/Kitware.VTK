using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPerlinNoise : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPerlinNoise";

		public new static readonly string MRClassNameKey;

		static vtkPerlinNoise()
		{
			vtkPerlinNoise.MRClassNameKey = "class vtkPerlinNoise";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPerlinNoise.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerlinNoise"));
		}

		public vtkPerlinNoise(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPerlinNoise_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPerlinNoise New()
		{
			vtkPerlinNoise result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPerlinNoise() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPerlinNoise.vtkPerlinNoise_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPerlinNoise_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPerlinNoise.vtkPerlinNoise_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPerlinNoise_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkPerlinNoise.vtkPerlinNoise_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkPerlinNoise.vtkPerlinNoise_EvaluateGradient_03(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPerlinNoise_GetAmplitude_04(HandleRef pThis);

		public virtual double GetAmplitude()
		{
			return vtkPerlinNoise.vtkPerlinNoise_GetAmplitude_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPerlinNoise_GetFrequency_05(HandleRef pThis);

		public virtual double[] GetFrequency()
		{
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_GetFrequency_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_GetFrequency_06(HandleRef pThis, IntPtr data);

		public virtual void GetFrequency(IntPtr data)
		{
			vtkPerlinNoise.vtkPerlinNoise_GetFrequency_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPerlinNoise_GetPhase_07(HandleRef pThis);

		public virtual double[] GetPhase()
		{
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_GetPhase_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_GetPhase_08(HandleRef pThis, IntPtr data);

		public virtual void GetPhase(IntPtr data)
		{
			vtkPerlinNoise.vtkPerlinNoise_GetPhase_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPerlinNoise_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPerlinNoise.vtkPerlinNoise_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPerlinNoise_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPerlinNoise.vtkPerlinNoise_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPerlinNoise_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPerlinNoise NewInstance()
		{
			vtkPerlinNoise result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPerlinNoise_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPerlinNoise SafeDownCast(vtkObjectBase o)
		{
			vtkPerlinNoise vtkPerlinNoise = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerlinNoise = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerlinNoise.Register(null);
				}
			}
			return vtkPerlinNoise;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_SetAmplitude_14(HandleRef pThis, double _arg);

		public virtual void SetAmplitude(double _arg)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetAmplitude_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_SetFrequency_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetFrequency(double _arg1, double _arg2, double _arg3)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetFrequency_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_SetFrequency_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetFrequency(IntPtr _arg)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetFrequency_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_SetPhase_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPhase(double _arg1, double _arg2, double _arg3)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetPhase_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPerlinNoise_SetPhase_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetPhase(IntPtr _arg)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetPhase_18(base.GetCppThis(), _arg);
		}
	}
}
