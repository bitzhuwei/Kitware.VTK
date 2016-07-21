using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPipelineSize : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPipelineSize";

		public new static readonly string MRClassNameKey;

		static vtkPipelineSize()
		{
			vtkPipelineSize.MRClassNameKey = "class vtkPipelineSize";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPipelineSize.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPipelineSize"));
		}

		public vtkPipelineSize(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPipelineSize_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPipelineSize New()
		{
			vtkPipelineSize result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPipelineSize.vtkPipelineSize_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPipelineSize)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPipelineSize() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPipelineSize.vtkPipelineSize_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkPipelineSize_GetEstimatedSize_01(HandleRef pThis, HandleRef input, int inputPort, int connection);

		public uint GetEstimatedSize(vtkAlgorithm input, int inputPort, int connection)
		{
			return vtkPipelineSize.vtkPipelineSize_GetEstimatedSize_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), inputPort, connection);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkPipelineSize_GetNumberOfSubPieces_02(HandleRef pThis, uint memoryLimit, HandleRef mapper);

		public uint GetNumberOfSubPieces(uint memoryLimit, vtkPolyDataMapper mapper)
		{
			return vtkPipelineSize.vtkPipelineSize_GetNumberOfSubPieces_02(base.GetCppThis(), memoryLimit, (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPipelineSize_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPipelineSize.vtkPipelineSize_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPipelineSize_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPipelineSize.vtkPipelineSize_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPipelineSize_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPipelineSize NewInstance()
		{
			vtkPipelineSize result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPipelineSize.vtkPipelineSize_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPipelineSize)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPipelineSize_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPipelineSize SafeDownCast(vtkObjectBase o)
		{
			vtkPipelineSize vtkPipelineSize = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPipelineSize.vtkPipelineSize_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPipelineSize = (vtkPipelineSize)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPipelineSize.Register(null);
				}
			}
			return vtkPipelineSize;
		}
	}
}
