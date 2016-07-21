using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGeoSource : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoSource()
		{
			vtkGeoSource.MRClassNameKey = "class vtkGeoSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoSource"));
		}

		public vtkGeoSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoSource_FetchChild_01(HandleRef pThis, HandleRef node, int index, HandleRef child);

		public virtual bool FetchChild(vtkGeoTreeNode node, int index, vtkGeoTreeNode child)
		{
			return vtkGeoSource.vtkGeoSource_FetchChild_01(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), index, (child == null) ? default(HandleRef) : child.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoSource_FetchRoot_02(HandleRef pThis, HandleRef root);

		public virtual bool FetchRoot(vtkGeoTreeNode root)
		{
			return vtkGeoSource.vtkGeoSource_FetchRoot_02(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSource_GetRequestedNodes_03(HandleRef pThis, HandleRef node, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCollection GetRequestedNodes(vtkGeoTreeNode node)
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSource.vtkGeoSource_GetRequestedNodes_03(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSource_GetTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSource.vtkGeoSource_GetTransform_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSource_Initialize_05(HandleRef pThis, int numThreads);

		public void Initialize(int numThreads)
		{
			vtkGeoSource.vtkGeoSource_Initialize_05(base.GetCppThis(), numThreads);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSource_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoSource.vtkGeoSource_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSource_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoSource.vtkGeoSource_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoSource NewInstance()
		{
			vtkGeoSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSource.vtkGeoSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSource_RequestChildren_09(HandleRef pThis, HandleRef node);

		public virtual void RequestChildren(vtkGeoTreeNode node)
		{
			vtkGeoSource.vtkGeoSource_RequestChildren_09(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoSource vtkGeoSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSource.vtkGeoSource_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoSource = (vtkGeoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoSource.Register(null);
				}
			}
			return vtkGeoSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSource_ShutDown_11(HandleRef pThis);

		public void ShutDown()
		{
			vtkGeoSource.vtkGeoSource_ShutDown_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSource_WorkerThread_12(HandleRef pThis);

		public void WorkerThread()
		{
			vtkGeoSource.vtkGeoSource_WorkerThread_12(base.GetCppThis());
		}
	}
}
