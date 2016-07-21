using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAbstractContextItem : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractContextItem";

		public new static readonly string MRClassNameKey;

		static vtkAbstractContextItem()
		{
			vtkAbstractContextItem.MRClassNameKey = "class vtkAbstractContextItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractContextItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractContextItem"));
		}

		public vtkAbstractContextItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern uint vtkAbstractContextItem_AddItem_01(HandleRef pThis, HandleRef item);

		public uint AddItem(vtkAbstractContextItem item)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_AddItem_01(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAbstractContextItem_ClearItems_02(HandleRef pThis);

		public void ClearItems()
		{
			vtkAbstractContextItem.vtkAbstractContextItem_ClearItems_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractContextItem_GetItem_03(HandleRef pThis, uint index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractContextItem GetItem(uint index)
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_GetItem_03(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkAbstractContextItem_GetNumberOfItems_04(HandleRef pThis);

		public uint GetNumberOfItems()
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetNumberOfItems_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractContextItem_GetParent_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractContextItem GetParent()
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_GetParent_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAbstractContextItem_GetScene_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkContextScene GetScene()
		{
			vtkContextScene vtkContextScene = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_GetScene_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkAbstractContextItem_GetVisible_07(HandleRef pThis);

		public virtual bool GetVisible()
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_GetVisible_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAbstractContextItem_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkAbstractContextItem_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractContextItem_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractContextItem NewInstance()
		{
			vtkAbstractContextItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAbstractContextItem_Paint_11(HandleRef pThis, HandleRef painter);

		public virtual bool Paint(vtkContext2D painter)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAbstractContextItem_PaintChildren_12(HandleRef pThis, HandleRef painter);

		public bool PaintChildren(vtkContext2D painter)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_PaintChildren_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAbstractContextItem_ReleaseGraphicsResources_13(HandleRef pThis);

		public virtual void ReleaseGraphicsResources()
		{
			vtkAbstractContextItem.vtkAbstractContextItem_ReleaseGraphicsResources_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAbstractContextItem_RemoveItem_14(HandleRef pThis, HandleRef item);

		public bool RemoveItem(vtkAbstractContextItem item)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_RemoveItem_14(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkAbstractContextItem_RemoveItem_15(HandleRef pThis, uint index);

		public bool RemoveItem(uint index)
		{
			return vtkAbstractContextItem.vtkAbstractContextItem_RemoveItem_15(base.GetCppThis(), index) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractContextItem_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractContextItem SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractContextItem.vtkAbstractContextItem_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAbstractContextItem_SetParent_17(HandleRef pThis, HandleRef parent);

		public virtual void SetParent(vtkAbstractContextItem parent)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetParent_17(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAbstractContextItem_SetScene_18(HandleRef pThis, HandleRef scene);

		public virtual void SetScene(vtkContextScene scene)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetScene_18(base.GetCppThis(), (scene == null) ? default(HandleRef) : scene.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAbstractContextItem_SetVisible_19(HandleRef pThis, byte _arg);

		public virtual void SetVisible(bool _arg)
		{
			vtkAbstractContextItem.vtkAbstractContextItem_SetVisible_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkAbstractContextItem_Update_20(HandleRef pThis);

		public virtual void Update()
		{
			vtkAbstractContextItem.vtkAbstractContextItem_Update_20(base.GetCppThis());
		}
	}
}
