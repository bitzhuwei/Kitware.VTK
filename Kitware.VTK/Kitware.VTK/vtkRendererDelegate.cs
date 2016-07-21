using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRendererDelegate : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRendererDelegate";

		public new static readonly string MRClassNameKey;

		static vtkRendererDelegate()
		{
			vtkRendererDelegate.MRClassNameKey = "class vtkRendererDelegate";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRendererDelegate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererDelegate"));
		}

		public vtkRendererDelegate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkRendererDelegate_GetUsed_01(HandleRef pThis);

		public virtual bool GetUsed()
		{
			return vtkRendererDelegate.vtkRendererDelegate_GetUsed_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererDelegate_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRendererDelegate.vtkRendererDelegate_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRendererDelegate_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRendererDelegate.vtkRendererDelegate_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererDelegate_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRendererDelegate NewInstance()
		{
			vtkRendererDelegate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererDelegate.vtkRendererDelegate_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererDelegate_Render_05(HandleRef pThis, HandleRef r);

		public virtual void Render(vtkRenderer r)
		{
			vtkRendererDelegate.vtkRendererDelegate_Render_05(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRendererDelegate_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRendererDelegate SafeDownCast(vtkObjectBase o)
		{
			vtkRendererDelegate vtkRendererDelegate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRendererDelegate.vtkRendererDelegate_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererDelegate = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererDelegate.Register(null);
				}
			}
			return vtkRendererDelegate;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererDelegate_SetUsed_07(HandleRef pThis, byte _arg);

		public virtual void SetUsed(bool _arg)
		{
            vtkRendererDelegate.vtkRendererDelegate_SetUsed_07(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererDelegate_UsedOff_08(HandleRef pThis);

		public virtual void UsedOff()
		{
			vtkRendererDelegate.vtkRendererDelegate_UsedOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRendererDelegate_UsedOn_09(HandleRef pThis);

		public virtual void UsedOn()
		{
			vtkRendererDelegate.vtkRendererDelegate_UsedOn_09(base.GetCppThis());
		}
	}
}
