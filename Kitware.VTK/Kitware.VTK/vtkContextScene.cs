using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContextScene : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextScene";

		public new static readonly string MRClassNameKey;

		static vtkContextScene()
		{
			vtkContextScene.MRClassNameKey = "class vtkContextScene";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextScene.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextScene"));
		}

		public vtkContextScene(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextScene New()
		{
			vtkContextScene result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextScene.vtkContextScene_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContextScene() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContextScene.vtkContextScene_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern uint vtkContextScene_AddItem_01(HandleRef pThis, HandleRef item);

		public uint AddItem(vtkAbstractContextItem item)
		{
			return vtkContextScene.vtkContextScene_AddItem_01(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_ClearItems_02(HandleRef pThis);

		public void ClearItems()
		{
			vtkContextScene.vtkContextScene_ClearItems_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_GetAnnotationLink_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetAnnotationLink_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_GetDirty_04(HandleRef pThis);

		public bool GetDirty()
		{
			return vtkContextScene.vtkContextScene_GetDirty_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_GetGeometry_05(HandleRef pThis);

		public virtual int[] GetGeometry()
		{
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetGeometry_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_GetGeometry_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetGeometry(ref int _arg1, ref int _arg2)
		{
			vtkContextScene.vtkContextScene_GetGeometry_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_GetGeometry_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetGeometry(IntPtr _arg)
		{
			vtkContextScene.vtkContextScene_GetGeometry_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_GetItem_08(HandleRef pThis, uint index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractContextItem GetItem(uint index)
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetItem_08(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractContextItem = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractContextItem.Register(null);
				}
			}
			return vtkAbstractContextItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern uint vtkContextScene_GetNumberOfItems_09(HandleRef pThis);

		public uint GetNumberOfItems()
		{
			return vtkContextScene.vtkContextScene_GetNumberOfItems_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_GetScaleTiles_10(HandleRef pThis);

		public virtual bool GetScaleTiles()
		{
			return vtkContextScene.vtkContextScene_GetScaleTiles_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextScene_GetSceneHeight_11(HandleRef pThis);

		public int GetSceneHeight()
		{
			return vtkContextScene.vtkContextScene_GetSceneHeight_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextScene_GetSceneWidth_12(HandleRef pThis);

		public int GetSceneWidth()
		{
			return vtkContextScene.vtkContextScene_GetSceneWidth_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_GetTransform_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTransform2D GetTransform()
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextScene.vtkContextScene_GetTransform_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_GetUseBufferId_14(HandleRef pThis);

		public virtual bool GetUseBufferId()
		{
			return vtkContextScene.vtkContextScene_GetUseBufferId_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextScene_GetViewHeight_15(HandleRef pThis);

		public virtual int GetViewHeight()
		{
			return vtkContextScene.vtkContextScene_GetViewHeight_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextScene_GetViewWidth_16(HandleRef pThis);

		public virtual int GetViewWidth()
		{
			return vtkContextScene.vtkContextScene_GetViewWidth_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_HasTransform_17(HandleRef pThis);

		public bool HasTransform()
		{
			return vtkContextScene.vtkContextScene_HasTransform_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextScene_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextScene.vtkContextScene_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextScene_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextScene.vtkContextScene_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextScene NewInstance()
		{
			vtkContextScene result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextScene.vtkContextScene_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_Paint_22(HandleRef pThis, HandleRef painter);

		public virtual bool Paint(vtkContext2D painter)
		{
			return vtkContextScene.vtkContextScene_Paint_22(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_ReleaseGraphicsResources_23(HandleRef pThis);

		public void ReleaseGraphicsResources()
		{
			vtkContextScene.vtkContextScene_ReleaseGraphicsResources_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_RemoveItem_24(HandleRef pThis, HandleRef item);

		public bool RemoveItem(vtkAbstractContextItem item)
		{
			return vtkContextScene.vtkContextScene_RemoveItem_24(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextScene_RemoveItem_25(HandleRef pThis, uint index);

		public bool RemoveItem(uint index)
		{
			return vtkContextScene.vtkContextScene_RemoveItem_25(base.GetCppThis(), index) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextScene_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextScene SafeDownCast(vtkObjectBase o)
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextScene.vtkContextScene_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextScene = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextScene.Register(null);
				}
			}
			return vtkContextScene;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_ScaleTilesOff_27(HandleRef pThis);

		public virtual void ScaleTilesOff()
		{
			vtkContextScene.vtkContextScene_ScaleTilesOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_ScaleTilesOn_28(HandleRef pThis);

		public virtual void ScaleTilesOn()
		{
			vtkContextScene.vtkContextScene_ScaleTilesOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetAnnotationLink_29(HandleRef pThis, HandleRef link);

		public virtual void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkContextScene.vtkContextScene_SetAnnotationLink_29(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetDirty_30(HandleRef pThis, byte isDirty);

		public void SetDirty(bool isDirty)
		{
			vtkContextScene.vtkContextScene_SetDirty_30(base.GetCppThis(), isDirty ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetGeometry_31(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetGeometry(int _arg1, int _arg2)
		{
			vtkContextScene.vtkContextScene_SetGeometry_31(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetGeometry_32(HandleRef pThis, IntPtr _arg);

		public void SetGeometry(IntPtr _arg)
		{
			vtkContextScene.vtkContextScene_SetGeometry_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetRenderer_33(HandleRef pThis, HandleRef renderer);

		public virtual void SetRenderer(vtkRenderer renderer)
		{
			vtkContextScene.vtkContextScene_SetRenderer_33(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetScaleTiles_34(HandleRef pThis, byte _arg);

		public virtual void SetScaleTiles(bool _arg)
		{
			vtkContextScene.vtkContextScene_SetScaleTiles_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetTransform_35(HandleRef pThis, HandleRef transform);

		public virtual void SetTransform(vtkTransform2D transform)
		{
			vtkContextScene.vtkContextScene_SetTransform_35(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextScene_SetUseBufferId_36(HandleRef pThis, byte _arg);

		public virtual void SetUseBufferId(bool _arg)
		{
			vtkContextScene.vtkContextScene_SetUseBufferId_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
