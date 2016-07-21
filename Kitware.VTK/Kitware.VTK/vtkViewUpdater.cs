using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkViewUpdater : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewUpdater";

		public new static readonly string MRClassNameKey;

		static vtkViewUpdater()
		{
			vtkViewUpdater.MRClassNameKey = "class vtkViewUpdater";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewUpdater.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewUpdater"));
		}

		public vtkViewUpdater(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkViewUpdater_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewUpdater New()
		{
			vtkViewUpdater result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewUpdater.vtkViewUpdater_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewUpdater)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkViewUpdater() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkViewUpdater.vtkViewUpdater_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkViewUpdater_AddAnnotationLink_01(HandleRef pThis, HandleRef link);

		public void AddAnnotationLink(vtkAnnotationLink link)
		{
			vtkViewUpdater.vtkViewUpdater_AddAnnotationLink_01(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkViewUpdater_AddView_02(HandleRef pThis, HandleRef view);

		public void AddView(vtkView view)
		{
			vtkViewUpdater.vtkViewUpdater_AddView_02(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkViewUpdater_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkViewUpdater.vtkViewUpdater_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkViewUpdater_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkViewUpdater.vtkViewUpdater_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkViewUpdater_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkViewUpdater NewInstance()
		{
			vtkViewUpdater result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewUpdater.vtkViewUpdater_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewUpdater)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkViewUpdater_RemoveView_07(HandleRef pThis, HandleRef view);

		public void RemoveView(vtkView view)
		{
			vtkViewUpdater.vtkViewUpdater_RemoveView_07(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkViewUpdater_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewUpdater SafeDownCast(vtkObjectBase o)
		{
			vtkViewUpdater vtkViewUpdater = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewUpdater.vtkViewUpdater_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewUpdater = (vtkViewUpdater)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewUpdater.Register(null);
				}
			}
			return vtkViewUpdater;
		}
	}
}
