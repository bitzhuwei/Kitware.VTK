using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMCubesWriter : vtkPolyDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMCubesWriter";

		public new static readonly string MRClassNameKey;

		static vtkMCubesWriter()
		{
			vtkMCubesWriter.MRClassNameKey = "class vtkMCubesWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMCubesWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMCubesWriter"));
		}

		public vtkMCubesWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMCubesWriter New()
		{
			vtkMCubesWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMCubesWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMCubesWriter.vtkMCubesWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesWriter_GetLimitsFileName_01(HandleRef pThis);

		public virtual string GetLimitsFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMCubesWriter.vtkMCubesWriter_GetLimitsFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesWriter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMCubesWriter.vtkMCubesWriter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesWriter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMCubesWriter.vtkMCubesWriter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMCubesWriter NewInstance()
		{
			vtkMCubesWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMCubesWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMCubesWriter vtkMCubesWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMCubesWriter = (vtkMCubesWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMCubesWriter.Register(null);
				}
			}
			return vtkMCubesWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesWriter_SetLimitsFileName_07(HandleRef pThis, string _arg);

		public virtual void SetLimitsFileName(string _arg)
		{
			vtkMCubesWriter.vtkMCubesWriter_SetLimitsFileName_07(base.GetCppThis(), _arg);
		}
	}
}
