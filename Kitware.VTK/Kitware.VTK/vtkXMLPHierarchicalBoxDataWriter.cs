using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPHierarchicalBoxDataWriter : vtkXMLHierarchicalBoxDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPHierarchicalBoxDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPHierarchicalBoxDataWriter()
		{
			vtkXMLPHierarchicalBoxDataWriter.MRClassNameKey = "class vtkXMLPHierarchicalBoxDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPHierarchicalBoxDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPHierarchicalBoxDataWriter"));
		}

		public vtkXMLPHierarchicalBoxDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPHierarchicalBoxDataWriter New()
		{
			vtkXMLPHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPHierarchicalBoxDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkXMLPHierarchicalBoxDataWriter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkXMLPHierarchicalBoxDataWriter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPHierarchicalBoxDataWriter NewInstance()
		{
			vtkXMLPHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPHierarchicalBoxDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPHierarchicalBoxDataWriter vtkXMLPHierarchicalBoxDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPHierarchicalBoxDataWriter = (vtkXMLPHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPHierarchicalBoxDataWriter.Register(null);
				}
			}
			return vtkXMLPHierarchicalBoxDataWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkXMLPHierarchicalBoxDataWriter_SetController_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkXMLPHierarchicalBoxDataWriter_SetWriteMetaFile_08(HandleRef pThis, int flag);

		public override void SetWriteMetaFile(int flag)
		{
			vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_SetWriteMetaFile_08(base.GetCppThis(), flag);
		}
	}
}
