using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCameraPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraPass";

		public new static readonly string MRClassNameKey;

		static vtkCameraPass()
		{
			vtkCameraPass.MRClassNameKey = "class vtkCameraPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraPass"));
		}

		public vtkCameraPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraPass New()
		{
			vtkCameraPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCameraPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCameraPass.vtkCameraPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCameraPass_GetAspectRatioOverride_01(HandleRef pThis);

		public virtual double GetAspectRatioOverride()
		{
			return vtkCameraPass.vtkCameraPass_GetAspectRatioOverride_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraPass_GetDelegatePass_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetDelegatePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_GetDelegatePass_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraPass_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCameraPass.vtkCameraPass_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraPass_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCameraPass.vtkCameraPass_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCameraPass NewInstance()
		{
			vtkCameraPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraPass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkCameraPass.vtkCameraPass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraPass SafeDownCast(vtkObjectBase o)
		{
			vtkCameraPass vtkCameraPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraPass = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraPass.Register(null);
				}
			}
			return vtkCameraPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraPass_SetAspectRatioOverride_09(HandleRef pThis, double _arg);

		public virtual void SetAspectRatioOverride(double _arg)
		{
			vtkCameraPass.vtkCameraPass_SetAspectRatioOverride_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraPass_SetDelegatePass_10(HandleRef pThis, HandleRef delegatePass);

		public virtual void SetDelegatePass(vtkRenderPass delegatePass)
		{
			vtkCameraPass.vtkCameraPass_SetDelegatePass_10(base.GetCppThis(), (delegatePass == null) ? default(HandleRef) : delegatePass.GetCppThis());
		}
	}
}
