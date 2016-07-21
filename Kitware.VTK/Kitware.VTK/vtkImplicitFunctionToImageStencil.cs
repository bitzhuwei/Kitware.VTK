using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitFunctionToImageStencil : vtkImageStencilSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitFunctionToImageStencil";

		public new static readonly string MRClassNameKey;

		static vtkImplicitFunctionToImageStencil()
		{
			vtkImplicitFunctionToImageStencil.MRClassNameKey = "class vtkImplicitFunctionToImageStencil";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitFunctionToImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitFunctionToImageStencil"));
		}

		public vtkImplicitFunctionToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitFunctionToImageStencil New()
		{
			vtkImplicitFunctionToImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunctionToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitFunctionToImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetInput()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImplicitFunctionToImageStencil_GetThreshold_02(HandleRef pThis);

		public virtual double GetThreshold()
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImplicitFunctionToImageStencil_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImplicitFunctionToImageStencil_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitFunctionToImageStencil NewInstance()
		{
			vtkImplicitFunctionToImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunctionToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitFunctionToImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitFunctionToImageStencil vtkImplicitFunctionToImageStencil = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunctionToImageStencil = (vtkImplicitFunctionToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunctionToImageStencil.Register(null);
				}
			}
			return vtkImplicitFunctionToImageStencil;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImplicitFunctionToImageStencil_SetInput_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkImplicitFunction arg0)
		{
			vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_SetInput_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImplicitFunctionToImageStencil_SetThreshold_09(HandleRef pThis, double _arg);

		public virtual void SetThreshold(double _arg)
		{
			vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_SetThreshold_09(base.GetCppThis(), _arg);
		}
	}
}
