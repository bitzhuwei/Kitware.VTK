using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSequencePass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSequencePass";

		public new static readonly string MRClassNameKey;

		static vtkSequencePass()
		{
			vtkSequencePass.MRClassNameKey = "class vtkSequencePass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSequencePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSequencePass"));
		}

		public vtkSequencePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSequencePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSequencePass New()
		{
			vtkSequencePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSequencePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSequencePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSequencePass.vtkSequencePass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSequencePass_GetPasses_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPassCollection GetPasses()
		{
			vtkRenderPassCollection vtkRenderPassCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_GetPasses_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPassCollection = (vtkRenderPassCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPassCollection.Register(null);
				}
			}
			return vtkRenderPassCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSequencePass_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSequencePass.vtkSequencePass_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSequencePass_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSequencePass.vtkSequencePass_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSequencePass_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSequencePass NewInstance()
		{
			vtkSequencePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSequencePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSequencePass_ReleaseGraphicsResources_06(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSequencePass.vtkSequencePass_ReleaseGraphicsResources_06(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSequencePass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSequencePass SafeDownCast(vtkObjectBase o)
		{
			vtkSequencePass vtkSequencePass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSequencePass.vtkSequencePass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSequencePass = (vtkSequencePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSequencePass.Register(null);
				}
			}
			return vtkSequencePass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSequencePass_SetPasses_08(HandleRef pThis, HandleRef passes);

		public virtual void SetPasses(vtkRenderPassCollection passes)
		{
			vtkSequencePass.vtkSequencePass_SetPasses_08(base.GetCppThis(), (passes == null) ? default(HandleRef) : passes.GetCppThis());
		}
	}
}
