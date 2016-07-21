using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericPointIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericPointIterator";

		public new static readonly string MRClassNameKey;

		static vtkGenericPointIterator()
		{
			vtkGenericPointIterator.MRClassNameKey = "class vtkGenericPointIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericPointIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericPointIterator"));
		}

		public vtkGenericPointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericPointIterator_Begin_01(HandleRef pThis);

		public virtual void Begin()
		{
			vtkGenericPointIterator.vtkGenericPointIterator_Begin_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericPointIterator_GetId_02(HandleRef pThis);

		public virtual long GetId()
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_GetId_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericPointIterator_GetPosition_03(HandleRef pThis);

		public virtual IntPtr GetPosition()
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_GetPosition_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericPointIterator_GetPosition_04(HandleRef pThis, IntPtr x);

		public virtual void GetPosition(IntPtr x)
		{
			vtkGenericPointIterator.vtkGenericPointIterator_GetPosition_04(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericPointIterator_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericPointIterator_IsAtEnd_06(HandleRef pThis);

		public virtual int IsAtEnd()
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_IsAtEnd_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericPointIterator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericPointIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericPointIterator NewInstance()
		{
			vtkGenericPointIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericPointIterator.vtkGenericPointIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericPointIterator_Next_09(HandleRef pThis);

		public virtual void Next()
		{
			vtkGenericPointIterator.vtkGenericPointIterator_Next_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericPointIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericPointIterator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericPointIterator vtkGenericPointIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericPointIterator.vtkGenericPointIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericPointIterator = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericPointIterator.Register(null);
				}
			}
			return vtkGenericPointIterator;
		}
	}
}
