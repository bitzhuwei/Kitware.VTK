using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLookupTableItem : vtkScalarsToColorsItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTableItem";

		public new static readonly string MRClassNameKey;

		static vtkLookupTableItem()
		{
			vtkLookupTableItem.MRClassNameKey = "class vtkLookupTableItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLookupTableItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTableItem"));
		}

		public vtkLookupTableItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLookupTableItem New()
		{
			vtkLookupTableItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLookupTableItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLookupTableItem.vtkLookupTableItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkLookupTableItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkLookupTableItem.vtkLookupTableItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableItem_GetLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_GetLookupTable_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkLookupTableItem_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLookupTableItem.vtkLookupTableItem_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkLookupTableItem_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLookupTableItem.vtkLookupTableItem_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLookupTableItem NewInstance()
		{
			vtkLookupTableItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableItem_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLookupTableItem SafeDownCast(vtkObjectBase o)
		{
			vtkLookupTableItem vtkLookupTableItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableItem.vtkLookupTableItem_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTableItem = (vtkLookupTableItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTableItem.Register(null);
				}
			}
			return vtkLookupTableItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkLookupTableItem_SetLookupTable_08(HandleRef pThis, HandleRef t);

		public void SetLookupTable(vtkLookupTable t)
		{
			vtkLookupTableItem.vtkLookupTableItem_SetLookupTable_08(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}
	}
}
