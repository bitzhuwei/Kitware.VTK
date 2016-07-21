using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeRayCastMIPFunction : vtkVolumeRayCastFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastMIPFunction";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRayCastMIPFunction()
		{
			vtkVolumeRayCastMIPFunction.MRClassNameKey = "class vtkVolumeRayCastMIPFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastMIPFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastMIPFunction"));
		}

		public vtkVolumeRayCastMIPFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMIPFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastMIPFunction New()
		{
			vtkVolumeRayCastMIPFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastMIPFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeRayCastMIPFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMIPFunction_GetMaximizeMethod_01(HandleRef pThis);

		public virtual int GetMaximizeMethod()
		{
			return vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_GetMaximizeMethod_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMIPFunction_GetMaximizeMethodAsString_02(HandleRef pThis);

		public string GetMaximizeMethodAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_GetMaximizeMethodAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMIPFunction_GetMaximizeMethodMaxValue_03(HandleRef pThis);

		public virtual int GetMaximizeMethodMaxValue()
		{
			return vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_GetMaximizeMethodMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMIPFunction_GetMaximizeMethodMinValue_04(HandleRef pThis);

		public virtual int GetMaximizeMethodMinValue()
		{
			return vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_GetMaximizeMethodMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastMIPFunction_GetZeroOpacityThreshold_05(HandleRef pThis, HandleRef vol);

		public override float GetZeroOpacityThreshold(vtkVolume vol)
		{
			return vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_GetZeroOpacityThreshold_05(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMIPFunction_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMIPFunction_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMIPFunction_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRayCastMIPFunction NewInstance()
		{
			vtkVolumeRayCastMIPFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastMIPFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMIPFunction_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastMIPFunction SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastMIPFunction vtkVolumeRayCastMIPFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastMIPFunction = (vtkVolumeRayCastMIPFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastMIPFunction.Register(null);
				}
			}
			return vtkVolumeRayCastMIPFunction;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMIPFunction_SetMaximizeMethod_11(HandleRef pThis, int _arg);

		public virtual void SetMaximizeMethod(int _arg)
		{
			vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_SetMaximizeMethod_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMIPFunction_SetMaximizeMethodToOpacity_12(HandleRef pThis);

		public void SetMaximizeMethodToOpacity()
		{
			vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_SetMaximizeMethodToOpacity_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMIPFunction_SetMaximizeMethodToScalarValue_13(HandleRef pThis);

		public void SetMaximizeMethodToScalarValue()
		{
			vtkVolumeRayCastMIPFunction.vtkVolumeRayCastMIPFunction_SetMaximizeMethodToScalarValue_13(base.GetCppThis());
		}
	}
}
