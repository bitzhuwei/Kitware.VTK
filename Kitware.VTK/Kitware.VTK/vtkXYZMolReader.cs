using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXYZMolReader : vtkMoleculeReaderBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXYZMolReader";

		public new static readonly string MRClassNameKey;

		static vtkXYZMolReader()
		{
			vtkXYZMolReader.MRClassNameKey = "class vtkXYZMolReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXYZMolReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYZMolReader"));
		}

		public vtkXYZMolReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXYZMolReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXYZMolReader New()
		{
			vtkXYZMolReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYZMolReader.vtkXYZMolReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXYZMolReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXYZMolReader.vtkXYZMolReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXYZMolReader_CanReadFile_01(HandleRef pThis, string name);

		public virtual int CanReadFile(string name)
		{
			return vtkXYZMolReader.vtkXYZMolReader_CanReadFile_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXYZMolReader_GetMaxTimeStep_02(HandleRef pThis);

		public virtual int GetMaxTimeStep()
		{
			return vtkXYZMolReader.vtkXYZMolReader_GetMaxTimeStep_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXYZMolReader_GetTimeStep_03(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkXYZMolReader.vtkXYZMolReader_GetTimeStep_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXYZMolReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXYZMolReader.vtkXYZMolReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXYZMolReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXYZMolReader.vtkXYZMolReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXYZMolReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXYZMolReader NewInstance()
		{
			vtkXYZMolReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYZMolReader.vtkXYZMolReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXYZMolReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXYZMolReader SafeDownCast(vtkObjectBase o)
		{
			vtkXYZMolReader vtkXYZMolReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXYZMolReader.vtkXYZMolReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYZMolReader = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYZMolReader.Register(null);
				}
			}
			return vtkXYZMolReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXYZMolReader_SetTimeStep_09(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkXYZMolReader.vtkXYZMolReader_SetTimeStep_09(base.GetCppThis(), _arg);
		}
	}
}
