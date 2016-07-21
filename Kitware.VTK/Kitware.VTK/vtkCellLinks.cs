using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellLinks : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLinks";

		public new static readonly string MRClassNameKey;

		static vtkCellLinks()
		{
			vtkCellLinks.MRClassNameKey = "class vtkCellLinks";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLinks.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLinks"));
		}

		public vtkCellLinks(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLinks_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellLinks New()
		{
			vtkCellLinks result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLinks.vtkCellLinks_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellLinks() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellLinks.vtkCellLinks_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_AddCellReference_01(HandleRef pThis, long cellId, long ptId);

		public void AddCellReference(long cellId, long ptId)
		{
			vtkCellLinks.vtkCellLinks_AddCellReference_01(base.GetCppThis(), cellId, ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_Allocate_02(HandleRef pThis, long numLinks, long ext);

		public void Allocate(long numLinks, long ext)
		{
			vtkCellLinks.vtkCellLinks_Allocate_02(base.GetCppThis(), numLinks, ext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_BuildLinks_03(HandleRef pThis, HandleRef data);

		public void BuildLinks(vtkDataSet data)
		{
			vtkCellLinks.vtkCellLinks_BuildLinks_03(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_BuildLinks_04(HandleRef pThis, HandleRef data, HandleRef Connectivity);

		public void BuildLinks(vtkDataSet data, vtkCellArray Connectivity)
		{
			vtkCellLinks.vtkCellLinks_BuildLinks_04(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (Connectivity == null) ? default(HandleRef) : Connectivity.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_DeepCopy_05(HandleRef pThis, HandleRef src);

		public void DeepCopy(vtkCellLinks src)
		{
			vtkCellLinks.vtkCellLinks_DeepCopy_05(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_DeletePoint_06(HandleRef pThis, long ptId);

		public void DeletePoint(long ptId)
		{
			vtkCellLinks.vtkCellLinks_DeletePoint_06(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkCellLinks_GetActualMemorySize_07(HandleRef pThis);

		public uint GetActualMemorySize()
		{
			return vtkCellLinks.vtkCellLinks_GetActualMemorySize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLinks_GetCells_08(HandleRef pThis, long ptId);

		public IntPtr GetCells(long ptId)
		{
			return vtkCellLinks.vtkCellLinks_GetCells_08(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern ushort vtkCellLinks_GetNcells_09(HandleRef pThis, long ptId);

		public ushort GetNcells(long ptId)
		{
			return vtkCellLinks.vtkCellLinks_GetNcells_09(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_InsertNextCellReference_10(HandleRef pThis, long ptId, long cellId);

		public void InsertNextCellReference(long ptId, long cellId)
		{
			vtkCellLinks.vtkCellLinks_InsertNextCellReference_10(base.GetCppThis(), ptId, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellLinks_InsertNextPoint_11(HandleRef pThis, int numLinks);

		public long InsertNextPoint(int numLinks)
		{
			return vtkCellLinks.vtkCellLinks_InsertNextPoint_11(base.GetCppThis(), numLinks);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLinks_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellLinks.vtkCellLinks_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLinks_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellLinks.vtkCellLinks_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLinks_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellLinks NewInstance()
		{
			vtkCellLinks result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLinks.vtkCellLinks_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_RemoveCellReference_16(HandleRef pThis, long cellId, long ptId);

		public void RemoveCellReference(long cellId, long ptId)
		{
			vtkCellLinks.vtkCellLinks_RemoveCellReference_16(base.GetCppThis(), cellId, ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_Reset_17(HandleRef pThis);

		public void Reset()
		{
			vtkCellLinks.vtkCellLinks_Reset_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_ResizeCellList_18(HandleRef pThis, long ptId, int size);

		public void ResizeCellList(long ptId, int size)
		{
			vtkCellLinks.vtkCellLinks_ResizeCellList_18(base.GetCppThis(), ptId, size);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLinks_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellLinks SafeDownCast(vtkObjectBase o)
		{
			vtkCellLinks vtkCellLinks = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLinks.vtkCellLinks_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLinks = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLinks.Register(null);
				}
			}
			return vtkCellLinks;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLinks_Squeeze_20(HandleRef pThis);

		public void Squeeze()
		{
			vtkCellLinks.vtkCellLinks_Squeeze_20(base.GetCppThis());
		}
	}
}
