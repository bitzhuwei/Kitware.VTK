using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSynchronizedRenderWindows : vtkObject
	{
		public enum SYNC_RENDER_TAG_WrapperEnum
		{
			SYNC_RENDER_TAG = 15001
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedRenderWindows";

		public new static readonly string MRClassNameKey;

		static vtkSynchronizedRenderWindows()
		{
			vtkSynchronizedRenderWindows.MRClassNameKey = "class vtkSynchronizedRenderWindows";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedRenderWindows.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedRenderWindows"));
		}

		public vtkSynchronizedRenderWindows(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderWindows_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedRenderWindows New()
		{
			vtkSynchronizedRenderWindows result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedRenderWindows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSynchronizedRenderWindows() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_AbortRender_01(HandleRef pThis);

		public virtual void AbortRender()
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_AbortRender_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkSynchronizedRenderWindows_GetIdentifier_02(HandleRef pThis);

		public virtual uint GetIdentifier()
		{
			return vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_GetIdentifier_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderWindows_GetParallelController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetParallelController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_GetParallelController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkSynchronizedRenderWindows_GetParallelRendering_04(HandleRef pThis);

		public virtual bool GetParallelRendering()
		{
			return vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_GetParallelRendering_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkSynchronizedRenderWindows_GetRenderEventPropagation_05(HandleRef pThis);

		public virtual bool GetRenderEventPropagation()
		{
			return vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_GetRenderEventPropagation_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderWindows_GetRenderWindow_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_GetRenderWindow_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderWindows_GetRootProcessId_07(HandleRef pThis);

		public virtual int GetRootProcessId()
		{
			return vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_GetRootProcessId_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderWindows_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderWindows_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderWindows_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSynchronizedRenderWindows NewInstance()
		{
			vtkSynchronizedRenderWindows result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedRenderWindows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_ParallelRenderingOff_12(HandleRef pThis);

		public virtual void ParallelRenderingOff()
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_ParallelRenderingOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_ParallelRenderingOn_13(HandleRef pThis);

		public virtual void ParallelRenderingOn()
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_ParallelRenderingOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_RenderEventPropagationOff_14(HandleRef pThis);

		public virtual void RenderEventPropagationOff()
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_RenderEventPropagationOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_RenderEventPropagationOn_15(HandleRef pThis);

		public virtual void RenderEventPropagationOn()
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_RenderEventPropagationOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderWindows_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedRenderWindows SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedRenderWindows vtkSynchronizedRenderWindows = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedRenderWindows = (vtkSynchronizedRenderWindows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedRenderWindows.Register(null);
				}
			}
			return vtkSynchronizedRenderWindows;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_SetIdentifier_17(HandleRef pThis, uint id);

		public void SetIdentifier(uint id)
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SetIdentifier_17(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_SetParallelController_18(HandleRef pThis, HandleRef arg0);

		public void SetParallelController(vtkMultiProcessController arg0)
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SetParallelController_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_SetParallelRendering_19(HandleRef pThis, byte _arg);

		public virtual void SetParallelRendering(bool _arg)
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SetParallelRendering_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_SetRenderEventPropagation_20(HandleRef pThis, byte _arg);

		public virtual void SetRenderEventPropagation(bool _arg)
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SetRenderEventPropagation_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_SetRenderWindow_21(HandleRef pThis, HandleRef arg0);

		public void SetRenderWindow(vtkRenderWindow arg0)
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SetRenderWindow_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderWindows_SetRootProcessId_22(HandleRef pThis, int _arg);

		public virtual void SetRootProcessId(int _arg)
		{
			vtkSynchronizedRenderWindows.vtkSynchronizedRenderWindows_SetRootProcessId_22(base.GetCppThis(), _arg);
		}
	}
}
