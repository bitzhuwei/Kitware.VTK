using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBalloonWidget : vtkHoverWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBalloonWidget";

		public new static readonly string MRClassNameKey;

		static vtkBalloonWidget()
		{
			vtkBalloonWidget.MRClassNameKey = "class vtkBalloonWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBalloonWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBalloonWidget"));
		}

		public vtkBalloonWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBalloonWidget New()
		{
			vtkBalloonWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBalloonWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBalloonWidget.vtkBalloonWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_AddBalloon_01(HandleRef pThis, HandleRef prop, string str, HandleRef img);

		public void AddBalloon(vtkProp prop, string str, vtkImageData img)
		{
			vtkBalloonWidget.vtkBalloonWidget_AddBalloon_01(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), str, (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_AddBalloon_02(HandleRef pThis, HandleRef prop, string str);

		public void AddBalloon(vtkProp prop, string str)
		{
			vtkBalloonWidget.vtkBalloonWidget_AddBalloon_02(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), str);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_CreateDefaultRepresentation_03(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkBalloonWidget.vtkBalloonWidget_CreateDefaultRepresentation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_GetBalloonImage_04(HandleRef pThis, HandleRef prop, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetBalloonImage(vtkProp prop)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetBalloonImage_04(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_GetBalloonRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBalloonRepresentation GetBalloonRepresentation()
		{
			vtkBalloonRepresentation vtkBalloonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetBalloonRepresentation_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonRepresentation = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonRepresentation.Register(null);
				}
			}
			return vtkBalloonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_GetBalloonString_06(HandleRef pThis, HandleRef prop);

		public string GetBalloonString(vtkProp prop)
		{
			return Marshal.PtrToStringAnsi(vtkBalloonWidget.vtkBalloonWidget_GetBalloonString_06(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_GetCurrentProp_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProp GetCurrentProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetCurrentProp_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_GetPicker_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractPropPicker GetPicker()
		{
			vtkAbstractPropPicker vtkAbstractPropPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetPicker_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPropPicker = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPropPicker.Register(null);
				}
			}
			return vtkAbstractPropPicker;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonWidget_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBalloonWidget.vtkBalloonWidget_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonWidget_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBalloonWidget.vtkBalloonWidget_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBalloonWidget NewInstance()
		{
			vtkBalloonWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_RemoveBalloon_13(HandleRef pThis, HandleRef prop);

		public void RemoveBalloon(vtkProp prop)
		{
			vtkBalloonWidget.vtkBalloonWidget_RemoveBalloon_13(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBalloonWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBalloonWidget vtkBalloonWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonWidget = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonWidget.Register(null);
				}
			}
			return vtkBalloonWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_SetEnabled_15(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkBalloonWidget.vtkBalloonWidget_SetEnabled_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_SetPicker_16(HandleRef pThis, HandleRef arg0);

		public void SetPicker(vtkAbstractPropPicker arg0)
		{
			vtkBalloonWidget.vtkBalloonWidget_SetPicker_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_SetRepresentation_17(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkBalloonRepresentation r)
		{
			vtkBalloonWidget.vtkBalloonWidget_SetRepresentation_17(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_UpdateBalloonImage_18(HandleRef pThis, HandleRef prop, HandleRef image);

		public void UpdateBalloonImage(vtkProp prop, vtkImageData image)
		{
			vtkBalloonWidget.vtkBalloonWidget_UpdateBalloonImage_18(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonWidget_UpdateBalloonString_19(HandleRef pThis, HandleRef prop, string str);

		public void UpdateBalloonString(vtkProp prop, string str)
		{
			vtkBalloonWidget.vtkBalloonWidget_UpdateBalloonString_19(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), str);
		}
	}
}
