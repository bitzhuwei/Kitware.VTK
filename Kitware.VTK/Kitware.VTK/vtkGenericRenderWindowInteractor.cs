using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericRenderWindowInteractor : vtkRenderWindowInteractor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericRenderWindowInteractor";

		public new static readonly string MRClassNameKey;

		static vtkGenericRenderWindowInteractor()
		{
			vtkGenericRenderWindowInteractor.MRClassNameKey = "class vtkGenericRenderWindowInteractor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericRenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericRenderWindowInteractor"));
		}

		public vtkGenericRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericRenderWindowInteractor New()
		{
			vtkGenericRenderWindowInteractor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericRenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericRenderWindowInteractor_GetTimerEventResetsTimer_01(HandleRef pThis);

		public virtual int GetTimerEventResetsTimer()
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_GetTimerEventResetsTimer_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericRenderWindowInteractor_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericRenderWindowInteractor_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericRenderWindowInteractor_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericRenderWindowInteractor NewInstance()
		{
			vtkGenericRenderWindowInteractor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericRenderWindowInteractor_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericRenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericRenderWindowInteractor = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericRenderWindowInteractor.Register(null);
				}
			}
			return vtkGenericRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericRenderWindowInteractor_SetTimerEventResetsTimer_07(HandleRef pThis, int _arg);

		public virtual void SetTimerEventResetsTimer(int _arg)
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_SetTimerEventResetsTimer_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericRenderWindowInteractor_TimerEvent_08(HandleRef pThis);

		public virtual void TimerEvent()
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_TimerEvent_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericRenderWindowInteractor_TimerEventResetsTimerOff_09(HandleRef pThis);

		public virtual void TimerEventResetsTimerOff()
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_TimerEventResetsTimerOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericRenderWindowInteractor_TimerEventResetsTimerOn_10(HandleRef pThis);

		public virtual void TimerEventResetsTimerOn()
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_TimerEventResetsTimerOn_10(base.GetCppThis());
		}
	}
}
