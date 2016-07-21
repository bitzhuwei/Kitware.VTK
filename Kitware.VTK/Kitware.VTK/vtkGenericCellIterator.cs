using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericCellIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCellIterator";

		public new static readonly string MRClassNameKey;

		static vtkGenericCellIterator()
		{
			vtkGenericCellIterator.MRClassNameKey = "class vtkGenericCellIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCellIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCellIterator"));
		}

		public vtkGenericCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellIterator_Begin_01(HandleRef pThis);

		public virtual void Begin()
		{
			vtkGenericCellIterator.vtkGenericCellIterator_Begin_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellIterator_GetCell_02(HandleRef pThis, HandleRef c);

		public virtual void GetCell(vtkGenericAdaptorCell c)
		{
			vtkGenericCellIterator.vtkGenericCellIterator_GetCell_02(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellIterator_GetCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericAdaptorCell GetCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_GetCell_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCellIterator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCellIterator_IsAtEnd_05(HandleRef pThis);

		public virtual int IsAtEnd()
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_IsAtEnd_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCellIterator_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellIterator_NewCell_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericAdaptorCell NewCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_NewCell_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericCellIterator NewInstance()
		{
			vtkGenericCellIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellIterator_Next_09(HandleRef pThis);

		public virtual void Next()
		{
			vtkGenericCellIterator.vtkGenericCellIterator_Next_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericCellIterator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}
	}
}
