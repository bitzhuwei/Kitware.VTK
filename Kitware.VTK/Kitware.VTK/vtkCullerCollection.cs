using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCullerCollection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCullerCollection";

		public new static readonly string MRClassNameKey;

		static vtkCullerCollection()
		{
			vtkCullerCollection.MRClassNameKey = "class vtkCullerCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCullerCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCullerCollection"));
		}

		public vtkCullerCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCullerCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCullerCollection New()
		{
			vtkCullerCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCullerCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCullerCollection.vtkCullerCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCullerCollection_AddItem_01(HandleRef pThis, HandleRef a);

		public void AddItem(vtkCuller a)
		{
			vtkCullerCollection.vtkCullerCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCullerCollection_GetLastItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCuller GetLastItem()
		{
			vtkCuller vtkCuller = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_GetLastItem_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCuller = (vtkCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCuller.Register(null);
				}
			}
			return vtkCuller;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCullerCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCuller GetNextItem()
		{
			vtkCuller vtkCuller = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCuller = (vtkCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCuller.Register(null);
				}
			}
			return vtkCuller;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCullerCollection_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCullerCollection.vtkCullerCollection_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCullerCollection_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCullerCollection.vtkCullerCollection_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCullerCollection_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCullerCollection NewInstance()
		{
			vtkCullerCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCullerCollection_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCullerCollection SafeDownCast(vtkObjectBase o)
		{
			vtkCullerCollection vtkCullerCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCullerCollection = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCullerCollection.Register(null);
				}
			}
			return vtkCullerCollection;
		}
	}
}
