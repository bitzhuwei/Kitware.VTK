using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCollection : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollection";

		public new static readonly string MRClassNameKey;

		static vtkCollection()
		{
			vtkCollection.MRClassNameKey = "class vtkCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollection"));
		}

		public vtkCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollection New()
		{
			vtkCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollection.vtkCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCollection.vtkCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_Register_13(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkCollection.vtkCollection_Register_13(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_UnRegister_19(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkCollection.vtkCollection_UnRegister_19(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

		public void AddItem(vtkObject arg0)
		{
			vtkCollection.vtkCollection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollection_GetItemAsObject_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObject GetItemAsObject(int i)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollection.vtkCollection_GetItemAsObject_02(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollection_GetNextItemAsObject_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObject GetNextItemAsObject()
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollection.vtkCollection_GetNextItemAsObject_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollection_GetNumberOfItems_04(HandleRef pThis);

		public int GetNumberOfItems()
		{
			return vtkCollection.vtkCollection_GetNumberOfItems_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_InitTraversal_05(HandleRef pThis);

		public void InitTraversal()
		{
			vtkCollection.vtkCollection_InitTraversal_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_InsertItem_06(HandleRef pThis, int i, HandleRef arg1);

		public void InsertItem(int i, vtkObject arg1)
		{
			vtkCollection.vtkCollection_InsertItem_06(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollection_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCollection.vtkCollection_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollection_IsItemPresent_08(HandleRef pThis, HandleRef a);

		public int IsItemPresent(vtkObject a)
		{
			return vtkCollection.vtkCollection_IsItemPresent_08(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCollection_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCollection.vtkCollection_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollection_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCollection NewInstance()
		{
			vtkCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollection.vtkCollection_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollection_NewIterator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCollectionIterator NewIterator()
		{
			vtkCollectionIterator vtkCollectionIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollection.vtkCollection_NewIterator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollectionIterator = (vtkCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollectionIterator.Register(null);
				}
			}
			return vtkCollectionIterator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_RemoveAllItems_14(HandleRef pThis);

		public void RemoveAllItems()
		{
			vtkCollection.vtkCollection_RemoveAllItems_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_RemoveItem_15(HandleRef pThis, int i);

		public void RemoveItem(int i)
		{
			vtkCollection.vtkCollection_RemoveItem_15(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_RemoveItem_16(HandleRef pThis, HandleRef arg0);

		public void RemoveItem(vtkObject arg0)
		{
			vtkCollection.vtkCollection_RemoveItem_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCollection_ReplaceItem_17(HandleRef pThis, int i, HandleRef arg1);

		public void ReplaceItem(int i, vtkObject arg1)
		{
			vtkCollection.vtkCollection_ReplaceItem_17(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCollection_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollection SafeDownCast(vtkObjectBase o)
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollection.vtkCollection_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}
	}
}
