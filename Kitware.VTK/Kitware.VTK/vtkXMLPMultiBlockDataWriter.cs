using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPMultiBlockDataWriter : vtkXMLMultiBlockDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPMultiBlockDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPMultiBlockDataWriter()
		{
			vtkXMLPMultiBlockDataWriter.MRClassNameKey = "class vtkXMLPMultiBlockDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPMultiBlockDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPMultiBlockDataWriter"));
		}

		public vtkXMLPMultiBlockDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPMultiBlockDataWriter New()
		{
			vtkXMLPMultiBlockDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPMultiBlockDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkXMLPMultiBlockDataWriter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkXMLPMultiBlockDataWriter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPMultiBlockDataWriter NewInstance()
		{
			vtkXMLPMultiBlockDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPMultiBlockDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPMultiBlockDataWriter vtkXMLPMultiBlockDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPMultiBlockDataWriter = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPMultiBlockDataWriter.Register(null);
				}
			}
			return vtkXMLPMultiBlockDataWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkXMLPMultiBlockDataWriter_SetController_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkXMLPMultiBlockDataWriter_SetWriteMetaFile_08(HandleRef pThis, int flag);

		public override void SetWriteMetaFile(int flag)
		{
			vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SetWriteMetaFile_08(base.GetCppThis(), flag);
		}
	}
}
