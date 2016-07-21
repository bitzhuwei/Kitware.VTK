using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractParticleWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractParticleWriter";

		public new static readonly string MRClassNameKey;

		static vtkAbstractParticleWriter()
		{
			vtkAbstractParticleWriter.MRClassNameKey = "class vtkAbstractParticleWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractParticleWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractParticleWriter"));
		}

		public vtkAbstractParticleWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_CloseFile_01(HandleRef pThis);

		public virtual void CloseFile()
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_CloseFile_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAbstractParticleWriter_GetCollectiveIO_02(HandleRef pThis);

		public virtual int GetCollectiveIO()
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetCollectiveIO_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractParticleWriter_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAbstractParticleWriter_GetTimeStep_04(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetTimeStep_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkAbstractParticleWriter_GetTimeValue_05(HandleRef pThis);

		public virtual double GetTimeValue()
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetTimeValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAbstractParticleWriter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAbstractParticleWriter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractParticleWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractParticleWriter NewInstance()
		{
			vtkAbstractParticleWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractParticleWriter.vtkAbstractParticleWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractParticleWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractParticleWriter SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractParticleWriter vtkAbstractParticleWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractParticleWriter.vtkAbstractParticleWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractParticleWriter = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractParticleWriter.Register(null);
				}
			}
			return vtkAbstractParticleWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_SetCollectiveIO_10(HandleRef pThis, int _arg);

		public virtual void SetCollectiveIO(int _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetCollectiveIO_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_SetFileName_11(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetFileName_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_SetTimeStep_12(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetTimeStep_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_SetTimeValue_13(HandleRef pThis, double _arg);

		public virtual void SetTimeValue(double _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetTimeValue_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_SetWriteModeToCollective_14(HandleRef pThis);

		public void SetWriteModeToCollective()
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetWriteModeToCollective_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAbstractParticleWriter_SetWriteModeToIndependent_15(HandleRef pThis);

		public void SetWriteModeToIndependent()
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetWriteModeToIndependent_15(base.GetCppThis());
		}
	}
}
