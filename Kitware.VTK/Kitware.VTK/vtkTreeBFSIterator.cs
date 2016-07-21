using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeBFSIterator : vtkObject
	{
		public enum ModeType
		{
			DISCOVER,
			FINISH
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeBFSIterator";

		public new static readonly string MRClassNameKey;

		static vtkTreeBFSIterator()
		{
			vtkTreeBFSIterator.MRClassNameKey = "class vtkTreeBFSIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeBFSIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeBFSIterator"));
		}

		public vtkTreeBFSIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeBFSIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeBFSIterator New()
		{
			vtkTreeBFSIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeBFSIterator.vtkTreeBFSIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeBFSIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeBFSIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeBFSIterator.vtkTreeBFSIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTreeBFSIterator_GetMode_01(HandleRef pThis);

		public virtual int GetMode()
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_GetMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTreeBFSIterator_GetStartVertex_02(HandleRef pThis);

		public virtual long GetStartVertex()
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_GetStartVertex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkTreeBFSIterator_HasNext_03(HandleRef pThis);

		public bool HasNext()
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_HasNext_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTreeBFSIterator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTreeBFSIterator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeBFSIterator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeBFSIterator NewInstance()
		{
			vtkTreeBFSIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeBFSIterator.vtkTreeBFSIterator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeBFSIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTreeBFSIterator_Next_08(HandleRef pThis);

		public long Next()
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_Next_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeBFSIterator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeBFSIterator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeBFSIterator vtkTreeBFSIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeBFSIterator.vtkTreeBFSIterator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeBFSIterator = (vtkTreeBFSIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeBFSIterator.Register(null);
				}
			}
			return vtkTreeBFSIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTreeBFSIterator_SetMode_10(HandleRef pThis, int mode);

		public void SetMode(int mode)
		{
			vtkTreeBFSIterator.vtkTreeBFSIterator_SetMode_10(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTreeBFSIterator_SetStartVertex_11(HandleRef pThis, long vertex);

		public void SetStartVertex(long vertex)
		{
			vtkTreeBFSIterator.vtkTreeBFSIterator_SetStartVertex_11(base.GetCppThis(), vertex);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTreeBFSIterator_SetTree_12(HandleRef pThis, HandleRef graph);

		public void SetTree(vtkTree graph)
		{
			vtkTreeBFSIterator.vtkTreeBFSIterator_SetTree_12(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}
	}
}
