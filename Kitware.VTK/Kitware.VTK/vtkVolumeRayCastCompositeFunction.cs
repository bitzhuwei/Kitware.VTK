using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeRayCastCompositeFunction : vtkVolumeRayCastFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastCompositeFunction";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRayCastCompositeFunction()
		{
			vtkVolumeRayCastCompositeFunction.MRClassNameKey = "class vtkVolumeRayCastCompositeFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastCompositeFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastCompositeFunction"));
		}

		public vtkVolumeRayCastCompositeFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastCompositeFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastCompositeFunction New()
		{
			vtkVolumeRayCastCompositeFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastCompositeFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeRayCastCompositeFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastCompositeFunction_GetCompositeMethod_01(HandleRef pThis);

		public virtual int GetCompositeMethod()
		{
			return vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_GetCompositeMethod_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastCompositeFunction_GetCompositeMethodAsString_02(HandleRef pThis);

		public string GetCompositeMethodAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_GetCompositeMethodAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastCompositeFunction_GetCompositeMethodMaxValue_03(HandleRef pThis);

		public virtual int GetCompositeMethodMaxValue()
		{
			return vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_GetCompositeMethodMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastCompositeFunction_GetCompositeMethodMinValue_04(HandleRef pThis);

		public virtual int GetCompositeMethodMinValue()
		{
			return vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_GetCompositeMethodMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastCompositeFunction_GetZeroOpacityThreshold_05(HandleRef pThis, HandleRef vol);

		public override float GetZeroOpacityThreshold(vtkVolume vol)
		{
			return vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_GetZeroOpacityThreshold_05(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastCompositeFunction_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastCompositeFunction_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastCompositeFunction_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRayCastCompositeFunction NewInstance()
		{
			vtkVolumeRayCastCompositeFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastCompositeFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastCompositeFunction_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastCompositeFunction SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastCompositeFunction vtkVolumeRayCastCompositeFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastCompositeFunction = (vtkVolumeRayCastCompositeFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastCompositeFunction.Register(null);
				}
			}
			return vtkVolumeRayCastCompositeFunction;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastCompositeFunction_SetCompositeMethod_11(HandleRef pThis, int _arg);

		public virtual void SetCompositeMethod(int _arg)
		{
			vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_SetCompositeMethod_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastCompositeFunction_SetCompositeMethodToClassifyFirst_12(HandleRef pThis);

		public void SetCompositeMethodToClassifyFirst()
		{
			vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_SetCompositeMethodToClassifyFirst_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastCompositeFunction_SetCompositeMethodToInterpolateFirst_13(HandleRef pThis);

		public void SetCompositeMethodToInterpolateFirst()
		{
			vtkVolumeRayCastCompositeFunction.vtkVolumeRayCastCompositeFunction_SetCompositeMethodToInterpolateFirst_13(base.GetCppThis());
		}
	}
}
