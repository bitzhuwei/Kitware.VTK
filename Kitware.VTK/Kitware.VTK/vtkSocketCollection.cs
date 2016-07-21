using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSocketCollection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocketCollection";

		public new static readonly string MRClassNameKey;

		static vtkSocketCollection()
		{
			vtkSocketCollection.MRClassNameKey = "class vtkSocketCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocketCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketCollection"));
		}

		public vtkSocketCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocketCollection New()
		{
			vtkSocketCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSocketCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSocketCollection.vtkSocketCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSocketCollection_AddItem_01(HandleRef pThis, HandleRef soc);

		public void AddItem(vtkSocket soc)
		{
			vtkSocketCollection.vtkSocketCollection_AddItem_01(base.GetCppThis(), (soc == null) ? default(HandleRef) : soc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCollection_GetLastSelectedSocket_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSocket GetLastSelectedSocket()
		{
			vtkSocket vtkSocket = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_GetLastSelectedSocket_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocket = (vtkSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocket.Register(null);
				}
			}
			return vtkSocket;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocketCollection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSocketCollection.vtkSocketCollection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocketCollection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSocketCollection.vtkSocketCollection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCollection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSocketCollection NewInstance()
		{
			vtkSocketCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSocketCollection_RemoveAllItems_07(HandleRef pThis);

		public new void RemoveAllItems()
		{
			vtkSocketCollection.vtkSocketCollection_RemoveAllItems_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSocketCollection_RemoveItem_08(HandleRef pThis, int i);

		public new void RemoveItem(int i)
		{
			vtkSocketCollection.vtkSocketCollection_RemoveItem_08(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSocketCollection_RemoveItem_09(HandleRef pThis, HandleRef arg0);

		public new void RemoveItem(vtkObject arg0)
		{
			vtkSocketCollection.vtkSocketCollection_RemoveItem_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSocketCollection_ReplaceItem_10(HandleRef pThis, int i, HandleRef arg1);

		public new void ReplaceItem(int i, vtkObject arg1)
		{
			vtkSocketCollection.vtkSocketCollection_ReplaceItem_10(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCollection_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocketCollection SafeDownCast(vtkObjectBase o)
		{
			vtkSocketCollection vtkSocketCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCollection.vtkSocketCollection_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketCollection = (vtkSocketCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketCollection.Register(null);
				}
			}
			return vtkSocketCollection;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocketCollection_SelectSockets_12(HandleRef pThis, uint msec);

		public int SelectSockets(uint msec)
		{
			return vtkSocketCollection.vtkSocketCollection_SelectSockets_12(base.GetCppThis(), msec);
		}
	}
}
