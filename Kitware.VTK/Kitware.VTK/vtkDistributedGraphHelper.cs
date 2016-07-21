using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDistributedGraphHelper : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedGraphHelper";

		public new static readonly string MRClassNameKey;

		static vtkDistributedGraphHelper()
		{
			vtkDistributedGraphHelper.MRClassNameKey = "class vtkDistributedGraphHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistributedGraphHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedGraphHelper"));
		}

		public vtkDistributedGraphHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedGraphHelper_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDistributedGraphHelper Clone()
		{
			vtkDistributedGraphHelper vtkDistributedGraphHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_Clone_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedGraphHelper = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedGraphHelper.Register(null);
				}
			}
			return vtkDistributedGraphHelper;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedGraphHelper_DISTRIBUTEDEDGEIDS_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DISTRIBUTEDEDGEIDS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_DISTRIBUTEDEDGEIDS_02(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedGraphHelper_DISTRIBUTEDVERTEXIDS_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DISTRIBUTEDVERTEXIDS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_DISTRIBUTEDVERTEXIDS_03(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDistributedGraphHelper_GetEdgeIndex_04(HandleRef pThis, long e_id);

		public long GetEdgeIndex(long e_id)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetEdgeIndex_04(base.GetCppThis(), e_id);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDistributedGraphHelper_GetEdgeOwner_05(HandleRef pThis, long e_id);

		public long GetEdgeOwner(long e_id)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetEdgeOwner_05(base.GetCppThis(), e_id);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDistributedGraphHelper_GetVertexIndex_06(HandleRef pThis, long v);

		public long GetVertexIndex(long v)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetVertexIndex_06(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDistributedGraphHelper_GetVertexOwner_07(HandleRef pThis, long v);

		public long GetVertexOwner(long v)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetVertexOwner_07(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDistributedGraphHelper_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDistributedGraphHelper_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDistributedGraphHelper_MakeDistributedId_10(HandleRef pThis, int owner, long local);

		public long MakeDistributedId(int owner, long local)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_MakeDistributedId_10(base.GetCppThis(), owner, local);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedGraphHelper_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistributedGraphHelper NewInstance()
		{
			vtkDistributedGraphHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedGraphHelper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistributedGraphHelper SafeDownCast(vtkObjectBase o)
		{
			vtkDistributedGraphHelper vtkDistributedGraphHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedGraphHelper = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedGraphHelper.Register(null);
				}
			}
			return vtkDistributedGraphHelper;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDistributedGraphHelper_Synchronize_13(HandleRef pThis);

		public virtual void Synchronize()
		{
			vtkDistributedGraphHelper.vtkDistributedGraphHelper_Synchronize_13(base.GetCppThis());
		}
	}
}
