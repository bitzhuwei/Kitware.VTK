using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeRayCastIsosurfaceFunction : vtkVolumeRayCastFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastIsosurfaceFunction";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRayCastIsosurfaceFunction()
		{
			vtkVolumeRayCastIsosurfaceFunction.MRClassNameKey = "class vtkVolumeRayCastIsosurfaceFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastIsosurfaceFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastIsosurfaceFunction"));
		}

		public vtkVolumeRayCastIsosurfaceFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastIsosurfaceFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastIsosurfaceFunction New()
		{
			vtkVolumeRayCastIsosurfaceFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastIsosurfaceFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeRayCastIsosurfaceFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastIsosurfaceFunction_GetIsoValue_01(HandleRef pThis);

		public virtual double GetIsoValue()
		{
			return vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_GetIsoValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastIsosurfaceFunction_GetZeroOpacityThreshold_02(HandleRef pThis, HandleRef vol);

		public override float GetZeroOpacityThreshold(vtkVolume vol)
		{
			return vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_GetZeroOpacityThreshold_02(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastIsosurfaceFunction_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastIsosurfaceFunction_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastIsosurfaceFunction_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRayCastIsosurfaceFunction NewInstance()
		{
			vtkVolumeRayCastIsosurfaceFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastIsosurfaceFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastIsosurfaceFunction_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastIsosurfaceFunction SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastIsosurfaceFunction vtkVolumeRayCastIsosurfaceFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastIsosurfaceFunction = (vtkVolumeRayCastIsosurfaceFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastIsosurfaceFunction.Register(null);
				}
			}
			return vtkVolumeRayCastIsosurfaceFunction;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastIsosurfaceFunction_SetIsoValue_08(HandleRef pThis, double _arg);

		public virtual void SetIsoValue(double _arg)
		{
			vtkVolumeRayCastIsosurfaceFunction.vtkVolumeRayCastIsosurfaceFunction_SetIsoValue_08(base.GetCppThis(), _arg);
		}
	}
}
