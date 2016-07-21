using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataCollection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataCollection";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataCollection()
		{
			vtkPolyDataCollection.MRClassNameKey = "class vtkPolyDataCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataCollection"));
		}

		public vtkPolyDataCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataCollection New()
		{
			vtkPolyDataCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataCollection.vtkPolyDataCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataCollection_AddItem_01(HandleRef pThis, HandleRef pd);

		public void AddItem(vtkPolyData pd)
		{
			vtkPolyDataCollection.vtkPolyDataCollection_AddItem_01(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetNextItem()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyDataCollection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataCollection.vtkPolyDataCollection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyDataCollection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataCollection.vtkPolyDataCollection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataCollection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataCollection NewInstance()
		{
			vtkPolyDataCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataCollection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataCollection SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataCollection vtkPolyDataCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataCollection = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataCollection.Register(null);
				}
			}
			return vtkPolyDataCollection;
		}
	}
}
