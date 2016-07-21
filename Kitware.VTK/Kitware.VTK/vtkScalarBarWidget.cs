using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkScalarBarWidget : vtkBorderWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarWidget";

		public new static readonly string MRClassNameKey;

		static vtkScalarBarWidget()
		{
			vtkScalarBarWidget.MRClassNameKey = "class vtkScalarBarWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarBarWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarWidget"));
		}

		public vtkScalarBarWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarBarWidget New()
		{
			vtkScalarBarWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkScalarBarWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkScalarBarWidget.vtkScalarBarWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkScalarBarWidget.vtkScalarBarWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarWidget_GetRepositionable_02(HandleRef pThis);

		public virtual int GetRepositionable()
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_GetRepositionable_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarWidget_GetScalarBarActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarBarActor GetScalarBarActor()
		{
			vtkScalarBarActor vtkScalarBarActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_GetScalarBarActor_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarActor = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarActor.Register(null);
				}
			}
			return vtkScalarBarActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarWidget_GetScalarBarRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkScalarBarRepresentation GetScalarBarRepresentation()
		{
			vtkScalarBarRepresentation vtkScalarBarRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_GetScalarBarRepresentation_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarRepresentation = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarRepresentation.Register(null);
				}
			}
			return vtkScalarBarRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarWidget_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarWidget_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScalarBarWidget.vtkScalarBarWidget_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScalarBarWidget NewInstance()
		{
			vtkScalarBarWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarWidget_RepositionableOff_09(HandleRef pThis);

		public virtual void RepositionableOff()
		{
			vtkScalarBarWidget.vtkScalarBarWidget_RepositionableOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarWidget_RepositionableOn_10(HandleRef pThis);

		public virtual void RepositionableOn()
		{
			vtkScalarBarWidget.vtkScalarBarWidget_RepositionableOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarBarWidget SafeDownCast(vtkObjectBase o)
		{
			vtkScalarBarWidget vtkScalarBarWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarWidget.vtkScalarBarWidget_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarWidget = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarWidget.Register(null);
				}
			}
			return vtkScalarBarWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarWidget_SetRepositionable_12(HandleRef pThis, int _arg);

		public virtual void SetRepositionable(int _arg)
		{
			vtkScalarBarWidget.vtkScalarBarWidget_SetRepositionable_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarWidget_SetRepresentation_13(HandleRef pThis, HandleRef rep);

		public virtual void SetRepresentation(vtkScalarBarRepresentation rep)
		{
			vtkScalarBarWidget.vtkScalarBarWidget_SetRepresentation_13(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarWidget_SetScalarBarActor_14(HandleRef pThis, HandleRef actor);

		public virtual void SetScalarBarActor(vtkScalarBarActor actor)
		{
			vtkScalarBarWidget.vtkScalarBarWidget_SetScalarBarActor_14(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}
	}
}
