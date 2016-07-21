using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeDFSIterator : vtkObject
	{
		public enum ModeType
		{
			DISCOVER,
			FINISH
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeDFSIterator";

		public new static readonly string MRClassNameKey;

		static vtkTreeDFSIterator()
		{
			vtkTreeDFSIterator.MRClassNameKey = "class vtkTreeDFSIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeDFSIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeDFSIterator"));
		}

		public vtkTreeDFSIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeDFSIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeDFSIterator New()
		{
			vtkTreeDFSIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeDFSIterator.vtkTreeDFSIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeDFSIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeDFSIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeDFSIterator.vtkTreeDFSIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTreeDFSIterator_GetMode_01(HandleRef pThis);

		public virtual int GetMode()
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_GetMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTreeDFSIterator_GetStartVertex_02(HandleRef pThis);

		public virtual long GetStartVertex()
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_GetStartVertex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkTreeDFSIterator_HasNext_03(HandleRef pThis);

		public bool HasNext()
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_HasNext_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTreeDFSIterator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTreeDFSIterator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeDFSIterator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeDFSIterator NewInstance()
		{
			vtkTreeDFSIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeDFSIterator.vtkTreeDFSIterator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeDFSIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTreeDFSIterator_Next_08(HandleRef pThis);

		public long Next()
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_Next_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeDFSIterator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeDFSIterator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeDFSIterator vtkTreeDFSIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeDFSIterator.vtkTreeDFSIterator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeDFSIterator = (vtkTreeDFSIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeDFSIterator.Register(null);
				}
			}
			return vtkTreeDFSIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTreeDFSIterator_SetMode_10(HandleRef pThis, int mode);

		public void SetMode(int mode)
		{
			vtkTreeDFSIterator.vtkTreeDFSIterator_SetMode_10(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTreeDFSIterator_SetStartVertex_11(HandleRef pThis, long vertex);

		public void SetStartVertex(long vertex)
		{
			vtkTreeDFSIterator.vtkTreeDFSIterator_SetStartVertex_11(base.GetCppThis(), vertex);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTreeDFSIterator_SetTree_12(HandleRef pThis, HandleRef graph);

		public void SetTree(vtkTree graph)
		{
			vtkTreeDFSIterator.vtkTreeDFSIterator_SetTree_12(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}
	}
}
