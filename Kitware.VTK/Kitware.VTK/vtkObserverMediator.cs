using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkObserverMediator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkObserverMediator";

		public new static readonly string MRClassNameKey;

		static vtkObserverMediator()
		{
			vtkObserverMediator.MRClassNameKey = "class vtkObserverMediator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObserverMediator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObserverMediator"));
		}

		public vtkObserverMediator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkObserverMediator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkObserverMediator New()
		{
			vtkObserverMediator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkObserverMediator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkObserverMediator.vtkObserverMediator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkObserverMediator_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_GetInteractor_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkObserverMediator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkObserverMediator.vtkObserverMediator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkObserverMediator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkObserverMediator.vtkObserverMediator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkObserverMediator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkObserverMediator NewInstance()
		{
			vtkObserverMediator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkObserverMediator_RemoveAllCursorShapeRequests_06(HandleRef pThis, HandleRef arg0);

		public void RemoveAllCursorShapeRequests(vtkInteractorObserver arg0)
		{
			vtkObserverMediator.vtkObserverMediator_RemoveAllCursorShapeRequests_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkObserverMediator_RequestCursorShape_07(HandleRef pThis, HandleRef arg0, int cursorShape);

		public int RequestCursorShape(vtkInteractorObserver arg0, int cursorShape)
		{
			return vtkObserverMediator.vtkObserverMediator_RequestCursorShape_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), cursorShape);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkObserverMediator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkObserverMediator SafeDownCast(vtkObjectBase o)
		{
			vtkObserverMediator vtkObserverMediator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObserverMediator = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObserverMediator.Register(null);
				}
			}
			return vtkObserverMediator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkObserverMediator_SetInteractor_09(HandleRef pThis, HandleRef iren);

		public void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkObserverMediator.vtkObserverMediator_SetInteractor_09(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}
	}
}
